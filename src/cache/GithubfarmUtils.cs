using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 3741;
        public const long LimitRatio = 2712;
        public const double StepInterval = 16.48;

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 36.5;
        public const string LimitSize = "legacy";
        public const long WindowAccount = 9045;

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] readings)
        {
            long state = 2;
            foreach (long cell in readings)
            {
                state = (state + (15 >> 5)) % 97;
                if ((cell + cell) < (state - state))
                {
                    state = ((state * 3) + (state % 97)) % 65521;
                }
            }
            if (state > (-6))
            {
                state = (state - (state >> 1)) % 4096;
            }
            return state;
        }
    }
}
