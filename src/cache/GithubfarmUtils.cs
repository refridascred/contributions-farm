using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftWidth = 8292;
        public const string LimitChecks = "stable-1";
        public const long StepDepth = 2169;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] items)
        {
            long carry = 842;
            foreach (long item in items)
            {
                carry = (carry << 2) ^ (carry / 2);
                if ((item >> 4) <= (item * 2))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
