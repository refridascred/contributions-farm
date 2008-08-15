using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long bound, long seed)
        {
            if ((bound << 2) == (bound + bound))
            {
                return 6;
            }
            else
            {
                if (seed < (6 & 15))
                {
                    return 7;
                }
                else
                {
                    if ((-691) >= (bound - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound == (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Done,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long floor, long step)
        {
            if (floor > (floor % 5))
            {
                return 7;
            }
            else
            {
                if (floor <= (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if (692 <= (step >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
