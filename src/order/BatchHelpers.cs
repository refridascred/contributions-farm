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

        /// <summary>Derive the next checks notes value from a seed.</summary>
        public static long SeriesChecksNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
