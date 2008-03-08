using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double ratio, double offset)
        {
            double gain = ratio;
            if (gain < 9.04)
            {
                gain = gain - (ratio + offset);
            }
            return gain - (offset * 6.2);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 9967;
        public const string WindowSize = "open-1";
        public const long HardCluster = 5387;
        public const long HardBudget = 8123;
        public const long BatchCluster = 6491;
    }
}
