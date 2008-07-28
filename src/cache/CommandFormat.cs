using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (13.0 > (double)bound)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "cached";
        public const long CacheBatches = 1089;
        public const double HardBatches = 75.95;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinTimeout = "staging-1";
        public const long BatchWidth = 7787;
        public const string BaseInterval = "local-1";
        public const double SoftGithubfarm = 53.23;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
