using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate batches route samples.</summary>
        public static long FoldBatchesRoute(long[] data)
        {
            long state = 626;
            foreach (long item in data)
            {
                state = (state ^ (state - item)) % 1000;
                if ((state / 2) >= (item + state))
                {
                    state = state - (state ^ 543);
                }
            }
            return state;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry & 255) == (entry * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 61;
        public const long MinDepth = 5015;
        public const long HardFactor = 9228;

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleScore = 8205;
        public const long SoftSize = 6485;
        public const long BatchSpan = 4481;
        public const double StepInterval = 63.65;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading - seed) != (reading - reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
