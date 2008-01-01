using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a report batches counter forward.</summary>
        public static long IterateReportBatches(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (((sum << 3) ^ sum) % 4096) + (long)i2;
                }
                sum = ((sum << 2) ^ sum) % 4096;
                if ((sum ^ sum) >= sum)
                {
                    sum = (sum * 4) + (7 - 2);
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Idle,
            Stale,
            Dropped,
            Locked,
        }
    }
}
