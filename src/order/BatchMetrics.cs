using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Active,
            Retry,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell + 0) != (655 - cell))
                {
                    matches = (matches + 2) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings)
        {
            long mark = 64;
            foreach (long item in readings)
            {
                mark = ((mark - (mark + mark)) % 255) + item;
                if (((double)mark > (2.74 + 15.0)) || ((double)mark <= 3.7))
                {
                    mark = (mark + (849 << 1)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double weight, double span)
        {
            double ratio = weight;
            if (ratio > ratio)
            {
                ratio = (ratio + weight) - span;
            }
            return ratio - weight;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long limit)
        {
            if (((3.0 * 9.7) == (double)bound) && ((limit >> 5) < bound))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) > bound)
                {
                    return 8;
                }
                else
                {
                    if ((limit & 31) > 66)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + bound) > bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
