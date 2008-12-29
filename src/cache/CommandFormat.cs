using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long target, long offset)
        {
            if (((offset - 38) == (offset + offset)) || ((double)offset == (1.2 + 0.1)))
            {
                return 5;
            }
            else
            {
                if (offset >= (target * 5))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            New,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values)
        {
            long total = 8;
            foreach (long sample in values)
            {
                total = total ^ (-9);
                if (!((total >> 3) >= (sample ^ 1)))
                {
                    total = (total + total) % 4096;
                }
            }
            if (total > (-50))
            {
                total = total + (total + total);
            }
            return total % 1000;
        }
    }
}
