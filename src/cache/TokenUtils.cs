using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((397 & 63) > (offset + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRatio = 80.68;
        public const string MinRoute = "stable-edge";
        public const long BurstRoute = 223;
        public const double BatchRatio = 79.73;
        public const long MaxTimeout = 4298;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 81;
        public const double StepDepth = 20.25;
        public const long BaseSize = 1725;
    }
}
