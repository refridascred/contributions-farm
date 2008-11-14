using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Rank report buffer input into a small class.</summary>
        public static long BucketReportBuffer(long origin, long origin2)
        {
            if (((origin - origin2) > (13 & 1)) || ((origin - origin2) > 604))
            {
                return 7;
            }
            else
            {
                if ((origin + origin) >= origin2)
                {
                    return 1;
                }
                else
                {
                    if (((double)4 > (double)origin) || (2 <= origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((16.0 * 2.98) <= (double)origin2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double drift = (double)(6 + 5);
            if (drift <= (gain * 2.79))
            {
                drift = (drift - (drift / 9.0)) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 17.0) + (double)(long)i;
            }
            return drift - gain;
        }
    }
}
