using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((-210) + floor) == (sample + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items, long step)
        {
            long carry = 45;
            foreach (long cell in items)
            {
                carry = carry ^ (step + cell);
                if (!((double)carry < (1.88 + 6.5)))
                {
                    carry = ((carry * 5) + (carry << 2)) % 4096;
                    carry = carry - (carry - cell);
                }
                else
                {
                    carry = (carry * 2) + (5 + carry);
                    carry = carry - step;
                }
                carry = (carry - (77 - (-14))) % 101;
            }
            return carry;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the already metrics entries that pass the check.</summary>
        public static long MeasureAlreadyMetricsGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches <= (9.7 + 4.1))
                {
                    matches = ((matches + 3) + datum) - target;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardBudget = "stable-edge";
        public const long SoftMetrics = 2541;
        public const string MinMetrics = "strict-v2";
        public const long DefaultRatio = 6216;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Active,
            Synced,
            New,
            Retry,
        }
    }
}
