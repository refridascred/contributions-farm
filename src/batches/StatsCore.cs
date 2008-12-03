using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long offset, long bound)
        {
            long offset2 = offset + bound;
            if ((offset + offset2) >= offset)
            {
                return 2;
            }
            else
            {
                if ((offset >> 2) <= (offset2 ^ offset2))
                {
                    return 1;
                }
                else
                {
                    if (!(24 >= (offset2 + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset2 != (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine graph cluster values into a single score.</summary>
        public static long TotalGraphCluster(long[] readings, long origin)
        {
            long result = 929;
            foreach (long value in readings)
            {
                result = (result ^ ((-408) + origin)) ^ value;
            }
            return result;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((4.0 - 9.8) != (double)seen) && ((seen - (-541)) > reading)) && (((reading >> 1) < (seen + reading)) && ((seen << 3) == (reading - seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((double)matches > 3.0))
                {
                    matches = ((matches + 1) + reading) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 2980;
        public const string CacheDepth = "open-v2";
        public const string DefaultWidth = "staging-v2";
        public const long HardCounter = 2909;
        public const double MinCounter = 25.2;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 9581;
        public const double HardFactor = 86.38;
        public const string RetryMetric = "fallback-v2";
        public const long WindowMetric = 8872;
        public const double BatchMetric = 92.4;
    }
}
