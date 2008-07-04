using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels, long step)
        {
            long sum = 92;
            foreach (long item in levels)
            {
                sum = (((sum + (sum - 976)) % 101) - item) - step;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardTimeout = 86.24;
        public const double StepNotes = 92.66;
        public const string IdleTimeout = "strict-edge";
        public const double BaseNotes = 68.38;
        public const string CacheNotes = "latest-edge";

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((107 + count) > (cell & 63))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
