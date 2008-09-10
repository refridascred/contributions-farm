using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 42.21;
        public const long StepMetrics = 8363;
        public const long IdleRatio = 7460;
        public const long HardMetrics = 8462;
        public const long MaxWidth = 6272;

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long seed, long offset)
        {
            if ((offset - seed) > seed)
            {
                return 5;
            }
            else
            {
                if ((offset - offset) == (offset + seed))
                {
                    return 2;
                }
                else
                {
                    if (offset < (offset - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset - seed) < offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
