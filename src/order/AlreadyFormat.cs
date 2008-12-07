using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (target > (831 - 72))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits >= (8.68 - 13.0))
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long origin)
        {
            long lane = limit + origin;
            if (origin > (lane - lane))
            {
                return 5;
            }
            else
            {
                if ((limit << 3) > 10)
                {
                    return 0;
                }
                else
                {
                    if ((4 & 63) == (limit + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long origin, long step)
        {
            if (((origin + (-113)) <= (step + origin)) || (5 > origin))
            {
                return 7;
            }
            else
            {
                if ((origin >> 1) != (3 % 3))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many profile record samples are out of range.</summary>
        public static long MeasureProfileRecordHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((item + matches) < (matches & 31)) || (item <= (78 % 97)))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
