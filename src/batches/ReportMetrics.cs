using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many cluster counter samples are out of range.</summary>
        public static long TallyClusterCounterOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen + 594) <= seen)
                {
                    seen = ((seen + 1) + entry) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen > (4.77 * 5.0))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long limit, long target)
        {
            if ((limit << 1) < limit)
            {
                return 1;
            }
            else
            {
                if ((limit - target) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((target + limit) != (limit - 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target >> 3) != (28 - 100))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
