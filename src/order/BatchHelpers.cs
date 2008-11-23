using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepSize = 3795;
        public const long BaseEditor = 8290;
        public const long BatchEditor = 2660;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every format record entry stays within the limit.</summary>
        public static bool CheckFormatRecordLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
