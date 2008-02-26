using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the window entry entries that pass the check.</summary>
        public static long TallyWindowEntryOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((((sample / 9) == (tally % 12)) || ((sample % 10) < floor)) && (((floor << 3) != (sample & 15)) && ((double)sample != (7.0 / 9.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultWidth = 188;
        public const long StepToken = 6697;
        public const double BaseTimeout = 40.97;
        public const long LimitToken = 8459;

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
