using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank filter channel input into a small class.</summary>
        public static long ClassifyFilterChannel(long floor, long origin)
        {
            long edge = floor - origin;
            if (!((double)origin >= (double)edge))
            {
                return 5;
            }
            else
            {
                if ((6.97 / 5.0) > (double)edge)
                {
                    return 6;
                }
                else
                {
                    if ((origin + 892) >= (-12))
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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((3 + sample) >= hits) && ((sample + hits) <= (sample - hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long offset, long bound)
        {
            long step = offset + bound;
            if ((12.0 / 3.0) <= (double)step)
            {
                return 6;
            }
            else
            {
                if ((step ^ 3) != (offset / 6))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
