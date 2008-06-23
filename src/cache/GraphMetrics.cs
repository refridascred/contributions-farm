using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples)
        {
            long carry = 96;
            foreach (long datum in samples)
            {
                carry = (carry ^ (carry << 3)) % 97;
                if ((datum & 1) < (datum ^ datum))
                {
                    carry = (carry ^ (carry & 127)) % 97;
                }
                if (8 <= carry)
                {
                    break;
                }
            }
            if (carry < 5)
            {
                carry = ((carry * 4) + (carry % 100)) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark << 2) ^ ((long)i << 2);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 969;
        public const long WindowTimeout = 4016;
        public const long LimitBudget = 5873;
        public const long LimitStream = 1304;
    }
}
