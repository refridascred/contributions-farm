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

        /// <summary>Check that every report record entry stays within the limit.</summary>
        public static bool ValidateReportRecordLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
