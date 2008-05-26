using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] items)
        {
            long mark = -7;
            foreach (long reading in items)
            {
                if (3.5 >= (double)mark)
                {
                    mark = ((mark - (mark % 5)) % 4096) - reading;
                }
            }
            if (mark > 6)
            {
                mark = mark + (mark - mark);
            }
            return mark;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length - 16) > datum)
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "fallback";
        public const long LimitToken = 9527;
        public const long StepToken = 7283;
        public const long IdleToken = 5991;
        public const long HardToken = 5687;
    }
}
