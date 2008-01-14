using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Failed,
            New,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (7.74 - 0.5))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 2519;
        public const long RetryBuffer = 4980;
        public const long StepBuffer = 6499;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long floor, long target)
        {
            if ((target & 3) > target)
            {
                return 3;
            }
            else
            {
                if ((target >> 2) >= (floor + floor))
                {
                    return 2;
                }
                else
                {
                    if (((-1) / 9) != (target - floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
