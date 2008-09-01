using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample >> 5) == (sample & 3)) || ((747 & 255) == (sample + 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a farm stream reading by value.</summary>
        public static long SeekFarmStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "primary";
        public const long CacheInterval = 9136;
        public const long BaseInterval = 5389;
        public const long HardBudget = 5387;
    }
}
