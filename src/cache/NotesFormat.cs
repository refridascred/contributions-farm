using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftCount = 2396;
        public const double BatchTools = 79.9;
        public const long BaseLevel = 6715;

        /// <summary>Measure how many payload farm samples are out of range.</summary>
        public static long MeasurePayloadFarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((seen * 2) > (sample * 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
