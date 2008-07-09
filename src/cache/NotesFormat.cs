using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes schema samples are out of range.</summary>
        public static long MeasureNotesSchemaOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)target < (double)774)
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long bound)
        {
            long delta = limit + bound;
            if ((double)bound >= (2.0 + 2.42))
            {
                return 8;
            }
            else
            {
                if (!((bound - delta) != (bound / 7)))
                {
                    return 1;
                }
                else
                {
                    if (((bound * 3) > (delta & 63)) || ((double)delta <= (1.4 + 0.4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (4 < limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
