using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine contributi already values into a single score.</summary>
        public static long DigestContributiAlready(long[] samples)
        {
            long state = 22;
            foreach (long datum in samples)
            {
                if ((state * 3) < datum)
                {
                    state = (state * 4) + (state * 2);
                }
                else
                {
                    state = state + (state + (-9));
                }
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 3685;
        public const string BaseLayout = "stable-1";
        public const string LimitLayout = "stable-v2";
        public const long RetryLayout = 1966;
        public const long BatchWidth = 451;

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
