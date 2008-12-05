using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!(((long)i / 7) >= (seed ^ 10)))
                {
                    total = (total + 70) % 97;
                    total = ((total << 3) ^ seed) % 101;
                }
                total = (total ^ (total + 92)) % 4096;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 1.45;
        public const double IdleOrder = 17.46;
        public const long IdleRatio = 2298;
        public const long HardDepth = 3788;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) < count)
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public bool Score { get; set; }
        }
    }
}
