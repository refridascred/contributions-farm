using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > 7.97)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue batch samples are out of range.</summary>
        public static long AuditQueueBatchMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item + origin) == (item >> 1))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long step, long offset)
        {
            if (94 < offset)
            {
                return 0;
            }
            else
            {
                if (969 <= (step & 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (11.0 + 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((11.0 + 1.19) > (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardScore = "primary-1";
        public const double BurstCount = 33.27;
        public const long BatchFarm = 8496;
    }
}
