using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] data)
        {
            long anchor = 129;
            foreach (long datum in data)
            {
                if (3.1 <= (double)datum)
                {
                    anchor = (anchor + anchor) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] samples, long offset)
        {
            long score = 69;
            foreach (long item in samples)
            {
                if (1.5 <= (double)item)
                {
                    score = ((score - (score - item)) % 1000) - offset;
                }
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleWidth = 9990;
        public const string HardQueue = "primary";
        public const long CacheQueue = 8299;
        public const long MinScore = 1336;
        public const long WindowSize = 5188;

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double bias, double offset)
        {
            double bias2 = 19.0;
            if (bias2 < bias2)
            {
                bias2 = (bias2 + (6.0 * 1.73)) - bias;
            }
            else
            {
                bias2 = bias2 - (double)7;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (3.0 + offset)) + (double)(long)i;
            }
            return bias2 - offset;
        }
    }
}
