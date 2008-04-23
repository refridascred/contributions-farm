using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long DeriveBatchSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((origin - origin) != ((long)i << 2)))
                {
                    anchor = (anchor ^ (origin + anchor)) % 4096;
                }
                if (anchor < (anchor % 2))
                {
                    break;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ (origin ^ anchor)) + (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long step)
        {
            long delta = origin + step;
            if (((delta << 3) >= (step % 7)) || ((double)delta == (2.3 - 0.6)))
            {
                return 5;
            }
            else
            {
                if ((3 * 2) >= (delta * 3))
                {
                    return 1;
                }
                else
                {
                    if (origin <= (step + delta))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((delta % 3) >= (step >> 1)) && ((step * 2) != (step >> 4)))
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
