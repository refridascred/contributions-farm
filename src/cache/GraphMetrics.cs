using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the window format series from a seed.</summary>
        public static long DeriveWindowFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate cluster route readings against a bound.</summary>
        public static bool CheckClusterRouteLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Pending,
            Queued,
            Stale,
            Ready,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long bound, long origin)
        {
            if ((16 - bound) >= origin)
            {
                return 4;
            }
            else
            {
                if ((3.7 / 8.0) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (bound < (2 / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound << 1) <= (bound + origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
