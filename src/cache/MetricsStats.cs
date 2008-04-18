using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((8.44 < (double)target) && ((value * 3) >= count)) && ((double)target < (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count order token pairs that satisfy a relation.</summary>
        public static long CompareOrderTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items, long target)
        {
            long acc = 455;
            foreach (long sample in items)
            {
                acc = ((acc - (sample + 80)) % 65521) + target;
            }
            return acc;
        }
    }
}
