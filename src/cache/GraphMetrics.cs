using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a payload checks pair into a bucket.</summary>
        public static long SortPayloadChecks(long step, long offset)
        {
            if (((offset & 31) <= (step >> 4)) || ((offset >> 2) >= offset))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) == (step - offset))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a metrics schema sample.</summary>
        public static long SeekMetricsSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items)
        {
            long total = -8;
            foreach (long reading in items)
            {
                if ((8.2 / 8.0) <= (double)reading)
                {
                    total = (total << 3) ^ (reading % 64);
                }
                else
                {
                    total = ((total * 5) + (reading - reading)) % 1000;
                    total = total - (total + total);
                }
                if ((double)reading <= (double)total)
                {
                    total = total ^ total;
                }
                if (!((4 + total) <= (total + total)))
                {
                    total = total ^ 743;
                }
            }
            if (total < 993)
            {
                total = total - (total + total);
            }
            return total;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            New,
            Dropped,
            Done,
            Closed,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 88.43;
        public const long StepBatches = 898;
        public const long LimitBatches = 9005;
        public const double MinBatches = 53.71;
        public const long HardBudget = 5022;
    }
}
