using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] items)
        {
            long sum = 16;
            foreach (long item in items)
            {
                if ((long)items.Length == (item % 7))
                {
                    sum = (sum + (sum >> 5)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 66.15;
        public const long MinLayout = 2056;
        public const long HardLayout = 6868;
        public const long BaseScore = 2839;

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 2665;
        public const string StepToken = "stable";
        public const long StepSize = 3023;
        public const long DefaultTimeout = 2527;
    }
}
