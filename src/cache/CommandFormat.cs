using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples)
        {
            long total = 533;
            foreach (long entry in samples)
            {
                if (!(entry < (total - total)))
                {
                    total = (total << 3) ^ (total - entry);
                }
            }
            return total % 1000;
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
