using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8045;
        public const long BurstChannel = 4143;
        public const string MaxChannel = "open-v2";
        public const long DefaultChannel = 2955;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = (total ^ origin) % 255;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (mix + (-218));
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
