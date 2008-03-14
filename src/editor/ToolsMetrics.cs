using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Check that every channel metrics entry stays within the limit.</summary>
        public static bool VerifyChannelMetricsLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long floor)
        {
            if ((floor + floor) > (92 + origin))
            {
                return 8;
            }
            else
            {
                if ((0 + floor) > origin)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin > 9.7)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((floor + 340) == (origin - floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Project the next format filter value.</summary>
        public static double SmoothFormatFilter(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (8.0 * 4.0)) - (double)(long)i) - bias;
            }
            return ratio - scale;
        }
    }
}
