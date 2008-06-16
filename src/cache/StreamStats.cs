using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit format order readings against a rule.</summary>
        public static long MeasureFormatOrderGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading * 2) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long floor, long target)
        {
            long prev = floor - target;
            if ((8 >> 2) > (floor - target))
            {
                return 2;
            }
            else
            {
                if (!(floor > 1))
                {
                    return 0;
                }
                else
                {
                    if (5.58 < (double)prev)
                    {
                        return 3;
                    }
                    else
                    {
                        if (267 <= (floor - 886))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long floor, long floor2)
        {
            long delta = floor ^ floor2;
            if ((double)delta < 5.39)
            {
                return 6;
            }
            else
            {
                if ((((-40) ^ floor2) > floor) || ((7 + delta) <= floor))
                {
                    return 1;
                }
                else
                {
                    if (((-332) ^ floor) < 52)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor << 2) != (delta % 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits < (offset - hits))
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
