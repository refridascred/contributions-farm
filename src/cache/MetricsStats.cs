using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] levels)
        {
            long anchor = 818;
            foreach (long item in levels)
            {
                anchor = ((anchor ^ (anchor + (long)levels.Length)) % 65521) + item;
            }
            if (anchor > (-3))
            {
                anchor = ((anchor << 2) ^ (anchor << 1)) % 101;
            }
            return anchor;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            New,
            Pending,
            Closed,
        }

        /// <summary>Match up stats account samples.</summary>
        public static long MatchStatsAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
