using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (88 <= (value / 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long step, long target)
        {
            if (step <= (target * 5))
            {
                return 3;
            }
            else
            {
                if ((target < (590 >> 2)) || ((double)target < (16.0 + 14.0)))
                {
                    return 1;
                }
                else
                {
                    if ((step > (step + step)) && ((8.11 * 2.7) >= (double)target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)target <= (3.0 * 7.8)) || (36 >= (step + step)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen >> 2) > datum)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }
    }
}
