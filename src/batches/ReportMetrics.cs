using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Done,
            Idle,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long step, long origin)
        {
            if ((origin >> 5) >= step)
            {
                return 7;
            }
            else
            {
                if (7.15 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin < step) && ((1 >> 4) < (step + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + step) != (872 - step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double weight, double span)
        {
            double drift = weight - (weight / 6.0);
            if (drift > (drift + weight))
            {
                drift = drift + (5.6 - span);
            }
            return drift + (double)5;
        }
    }
}
