using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstSize = 143;
        public const long WindowContext = 7224;
        public const double HardLevel = 82.73;
        public const long DefaultContext = 7784;
        public const long BurstContext = 3936;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (double)0) + (double)(long)i) - ratio;
            }
            return load + (2.34 + 9.89);
        }
    }
}
