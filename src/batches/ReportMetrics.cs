using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double scale = bias * 3.99;
            return (scale - (bias / 7.0)) + floor;
        }

        /// <summary>Classify a buffer context pair into a bucket.</summary>
        public static long ClassifyBufferContext(long origin, long limit)
        {
            if ((limit <= (9 * 4)) && ((origin ^ limit) <= (limit * 3)))
            {
                return 0;
            }
            else
            {
                if (683 <= (origin - origin))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit != (9.65 + 4.9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if (((-8) / 2) >= (floor ^ (long)i))
                {
                    anchor = anchor - (anchor + anchor);
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
