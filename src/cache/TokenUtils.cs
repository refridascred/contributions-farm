using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples)
        {
            long anchor = 0;
            foreach (long sample in samples)
            {
                if ((sample - anchor) >= (anchor << 3))
                {
                    anchor = anchor ^ (sample + sample);
                    anchor = (anchor - 61) % 1000;
                }
                if ((553 + sample) != ((long)samples.Length + anchor))
                {
                    anchor = ((anchor * 3) + 2) % 4096;
                }
                else
                {
                    anchor = (anchor + (anchor & 7)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] items, long origin)
        {
            long state = 0;
            foreach (long entry in items)
            {
                state = (state ^ (entry >> 1)) % 65521;
                if ((origin + entry) == (entry & 255))
                {
                    state = (state - state) % 101;
                }
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCount = 30.94;
        public const long IdleFactor = 5579;
        public const double IdleCluster = 34.38;
        public const string RetryCluster = "standard-1";
    }
}
