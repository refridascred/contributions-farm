using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + (floor - floor)) % 97;
                carry = ((carry * 5) + (168 * 4)) % 1000;
                carry = ((carry << 3) ^ 56) % 1000;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 39.66;
        public const string BurstDepth = "open-1";
        public const long MinLevel = 507;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Stale,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Count the farm batch entries that pass the check.</summary>
        public static long MeasureFarmBatchGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item ^ count) != (389 / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
