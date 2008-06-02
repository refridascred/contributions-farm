using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstBudget = 5385;
        public const long IdleCount = 8468;
        public const long RetryBudget = 5465;
        public const double BatchSchema = 81.48;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long offset, long bound)
        {
            long prev = offset - bound;
            if ((bound * 2) >= (5 * 4))
            {
                return 4;
            }
            else
            {
                if (prev > (offset % 24))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the notes record series from a seed.</summary>
        public static long SeriesNotesRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((1.4 + 3.18) <= (double)floor) || ((650 + 827) <= (floor + result)))
                {
                    result = result - floor;
                }
                else
                {
                    result = (result ^ (floor >> 1)) % 1000;
                }
                if (result < (floor - result))
                {
                    result = ((result << 3) ^ (floor + floor)) % 255;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
