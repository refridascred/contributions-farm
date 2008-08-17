using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardDepth = 712;
        public const double SoftNotes = 49.49;
        public const long StepNotes = 5136;
        public const long BurstDepth = 2795;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches % 2) > matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long offset, long floor)
        {
            long next = offset + floor;
            if (((offset % 60) <= next) || ((next - 780) == (offset & 127)))
            {
                return 8;
            }
            else
            {
                if (offset < (469 - floor))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
