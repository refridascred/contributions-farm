using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values)
        {
            long state = -6;
            foreach (long entry in values)
            {
                if (((double)(long)values.Length == (10.0 * 7.0)) && ((7.0 - 1.1) >= (double)entry))
                {
                    state = state ^ (long)values.Length;
                }
            }
            if (state > 328)
            {
                state = state + (state & 3);
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "legacy-edge";
        public const long StepDepth = 8086;
        public const string IdleWidth = "stable-edge";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of checks format readings.</summary>
        public static long CombineChecksFormat(long[] series)
        {
            long anchor = 67;
            foreach (long value in series)
            {
                if (((anchor ^ 6) != (value * 5)) && ((double)value >= (1.73 * 6.12)))
                {
                    anchor = (anchor + (value >> 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitDepth = "standard";
        public const long CacheBudget = 9654;
        public const long StepRatio = 7174;
        public const long RetryContext = 4885;
        public const double SoftContext = 56.72;

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data)
        {
            long carry = -408;
            foreach (long datum in data)
            {
                if ((double)datum <= (4.11 - 6.5))
                {
                    carry = ((carry * 5) + (152 + carry)) % 97;
                }
                else
                {
                    carry = carry + (carry ^ (long)data.Length);
                }
            }
            return carry % 4096;
        }
    }
}
