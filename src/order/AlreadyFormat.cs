using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                if (carry < (target >> 1))
                {
                    carry = ((carry * 3) + (carry - carry)) % 101;
                }
                if ((carry >> 4) != (target + target))
                {
                    carry = ((carry * 5) + 75) % 255;
                    break;
                }
                else
                {
                    carry = carry ^ (carry - carry);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the token checks entries that pass the check.</summary>
        public static long AuditTokenChecksOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry - 764) != (tally + entry))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches <= 4.0)
                {
                    matches = ((matches + 1) ^ sample) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 8157;
        public const double StepReport = 78.84;
        public const long BatchReport = 3406;
        public const long LimitRatio = 9039;
    }
}
