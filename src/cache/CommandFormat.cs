using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long seed, long floor)
        {
            if (!(seed >= (seed + seed)))
            {
                return 3;
            }
            else
            {
                if (((double)floor < (double)seed) || ((floor - (-12)) > (seed - floor)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 65;
        public const long SoftGithubfarm = 5437;
        public const double BurstBudget = 89.12;
        public const long BurstGithubfarm = 2284;
        public const string MinLevel = "open-v2";

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
