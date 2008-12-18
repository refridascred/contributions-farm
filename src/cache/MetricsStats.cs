using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long step, long step2)
        {
            long slot = step + step2;
            if ((slot + step2) > slot)
            {
                return 5;
            }
            else
            {
                if (!((41 + step2) == (step2 - (-80))))
                {
                    return 7;
                }
                else
                {
                    if ((step2 + step2) <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long bound)
        {
            long prev = step - bound;
            if ((double)bound <= (double)83)
            {
                return 4;
            }
            else
            {
                if (prev <= (prev >> 1))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a entry format pair into a bucket.</summary>
        public static long SortEntryFormat(long floor, long origin)
        {
            if (floor > 36)
            {
                return 7;
            }
            else
            {
                if ((floor + floor) > (505 + 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
