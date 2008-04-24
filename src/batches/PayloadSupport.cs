using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric route value against two limits.</summary>
        public static long ClassifyMetricRoute(long offset, long bound)
        {
            if ((bound & 255) != (offset << 2))
            {
                return 3;
            }
            else
            {
                if (((88 + bound) <= (5 / 9)) || ((offset - bound) <= (offset ^ bound)))
                {
                    return 8;
                }
                else
                {
                    if (4 < (bound >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((71 + offset) <= bound) && (10.0 > (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Ready,
            Synced,
            Locked,
            Active,
        }
    }
}
