using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSpan = 2903;
        public const double StepSupport = 41.45;
        public const double MaxTimeout = 62.27;
        public const long DefaultDepth = 5647;
        public const long DefaultFactor = 3961;

        /// <summary>Define route limits and defaults.</summary>
        public const double StepFactor = 31.54;
        public const long DefaultInterval = 1739;
        public const long DefaultWidth = 1841;
        public const string BurstLevel = "legacy-edge";
        public const string MaxRoute = "latest-1";

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                if (mix > (mix + 62))
                {
                    mix = (mix ^ (mix ^ mix)) % 97;
                    mix = ((mix << 3) ^ ((long)i + 498)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc + 7) % 65521;
                if (!(((1.95 - 9.2) != (double)acc) || ((double)offset < (5.3 / 8.0))))
                {
                    acc = (acc - ((-72) ^ 6)) % 101;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
