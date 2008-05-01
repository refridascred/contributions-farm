using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items, long limit)
        {
            long mix = 697;
            foreach (long item in items)
            {
                if ((double)mix <= (16.0 / 9.0))
                {
                    mix = ((mix << 3) ^ (limit & 7)) + item;
                }
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 18.43;
        public const string StepScore = "staging";
        public const long RetryWidth = 8367;
        public const string LimitRatio = "cached-v2";

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally >= 4.0)
                {
                    tally = ((tally + 2) + value) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
