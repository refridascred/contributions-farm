using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLevel = 85.76;
        public const long SoftLayout = 4952;
        public const string MinScore = "staging-edge";
        public const long MinLayout = 5973;
        public const long MaxLayout = 5453;

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up channel contributi samples.</summary>
        public static long MatchChannelContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long result = 8;
            foreach (long reading in series)
            {
                result = (result + (reading / 4)) % 65521;
                result = (result + 634) % 101;
            }
            if (result < 5)
            {
                result = (result * 5) + result;
            }
            return result;
        }
    }
}
