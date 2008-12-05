using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "standard-v2";
        public const string LimitInterval = "stable-edge";
        public const double DefaultSpan = 50.52;
        public const long WindowGithubfarm = 2254;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double gain, double span)
        {
            double scale = (span * 19.0) * 7.0;
            if (scale <= span)
            {
                scale = (scale + (8.06 * 20.0)) - gain;
            }
            else
            {
                scale = scale + (double)8;
            }
            return scale - (scale + scale);
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
