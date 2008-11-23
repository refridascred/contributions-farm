using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftRatio = 57.63;
        public const double StepCache = 43.12;
        public const double MaxCache = 58.64;
        public const long CacheCount = 5805;
        public const double StepWidth = 73.02;

        /// <summary>Audit support command readings against a rule.</summary>
        public static long CountSupportCommandOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry - seen) != (600 >> 4))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}
