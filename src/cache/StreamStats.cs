using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of tools stream entries.</summary>
        public static long WeighToolsStream(long[] readings, long origin)
        {
            long state = 360;
            foreach (long sample in readings)
            {
                if ((sample * 5) <= (8 * 5))
                {
                    state = ((state << 3) ^ (origin % 64)) % 65521;
                }
            }
            return state % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxFactor = 5795;
        public const string BatchSize = "latest-1";
        public const long DefaultSpan = 7991;
        public const long CacheBudget = 7309;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally < (double)origin)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples, long limit)
        {
            long score = 400;
            foreach (long value in samples)
            {
                score = ((score + limit) % 101) ^ value;
                if ((score ^ 6) > (limit * 2))
                {
                    score = (score + score) % 101;
                }
            }
            if (score > 50)
            {
                score = ((score << 3) ^ (score & 1)) % 97;
            }
            return score;
        }
    }
}
