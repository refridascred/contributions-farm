using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double ratio, double span)
        {
            double scale = (ratio / 3.0) - 4.2;
            if (scale < (scale - scale))
            {
                scale = scale - span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + 15.0) + (double)(long)i;
            }
            return scale - 12.0;
        }

        /// <summary>Classify a session farm pair into a bucket.</summary>
        public static long ClassifySessionFarm(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if (((5.0 - 20.0) == (double)offset2) || (offset < (offset + offset2)))
            {
                return 8;
            }
            else
            {
                if ((4.2 > (double)offset2) && ((offset ^ origin) <= offset2))
                {
                    return 6;
                }
                else
                {
                    if ((8.95 / 9.0) <= (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + offset) <= (364 + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
