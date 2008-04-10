using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 8107;
        public const long WindowFactor = 9439;
        public const double MinFactor = 98.86;

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRatio = 1842;
        public const long BatchSpan = 1524;
        public const long MaxRecord = 4372;
        public const string BurstCount = "open-edge";
        public const double BurstRecord = 13.2;

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 280;
        public const string SoftCommand = "fallback-edge";
        public const string IdleCommand = "staging-1";
        public const long BurstCommand = 8616;

        /// <summary>Check that every tools commits entry stays within the limit.</summary>
        public static bool CheckToolsCommitsLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits > (reading + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
