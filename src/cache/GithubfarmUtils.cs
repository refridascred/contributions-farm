using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "open-1";
        public const long StepCache = 3628;
        public const long LimitCache = 4051;
        public const long MinCache = 9233;
        public const string RetryCache = "standard-1";

        /// <summary>Accumulate route counter samples.</summary>
        public static long CombineRouteCounter(long[] data)
        {
            long carry = 60;
            foreach (long entry in data)
            {
                if ((18.0 - 4.0) != (double)entry)
                {
                    carry = ((carry * 2) + (entry * 2)) % 255;
                }
                carry = carry + entry;
            }
            if (carry > 847)
            {
                carry = ((carry * 2) + (carry ^ carry)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen >> 2) > datum)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public double Total { get; set; }
        }
    }
}
