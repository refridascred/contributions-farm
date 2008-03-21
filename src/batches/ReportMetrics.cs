using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 67.6;
        public const long MinFactor = 8535;
        public const long MinEntry = 9315;
        public const long LimitEntry = 2256;

        /// <summary>Validate context batch readings against a bound.</summary>
        public static bool VerifyContextBatchRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
