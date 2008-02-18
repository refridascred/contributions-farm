using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] samples, long seed)
        {
            long score = 75;
            foreach (long value in samples)
            {
                if ((seed << 1) == (score * 5))
                {
                    score = score ^ (seed << 1);
                }
                if (!((1 >> 5) >= (value % 7)))
                {
                    score = (score ^ (seed + value)) % 65521;
                    score = (score ^ (value - seed)) % 1000;
                }
                score = score ^ (seed % 97);
            }
            return score;
        }

        /// <summary>Measure how many schema stats samples are out of range.</summary>
        public static long TallySchemaStatsOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value > (1.3 * 7.41))
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up command stream samples.</summary>
        public static long OverlapCommandStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Failed,
            Draft,
            Queued,
            New,
        }
    }
}
