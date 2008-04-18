using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultLevel = 6235;
        public const double IdleBatches = 67.3;
        public const string BatchBatches = "cached";
        public const long DefaultScore = 2544;

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long origin, long target)
        {
            if ((origin & 15) >= target)
            {
                return 8;
            }
            else
            {
                if ((origin <= (target % 97)) && (89 <= (origin - origin)))
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin) <= (origin % 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry > 16.0)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long bound)
        {
            if ((bound & 3) < (seed % 12))
            {
                return 2;
            }
            else
            {
                if (((46 >> 5) < (bound * 3)) || ((5.57 * 17.0) == (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
