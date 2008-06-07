using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long origin, long bound)
        {
            if (((double)(-361) == (double)bound) && ((origin + bound) == (bound % 2)))
            {
                return 7;
            }
            else
            {
                if (!(0.2 > (double)origin))
                {
                    return 0;
                }
                else
                {
                    if (((38 - bound) > (bound / 9)) && ((origin / 9) != (70 ^ bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double drift = (double)781 * 1.0;
            if (drift <= drift)
            {
                drift = (drift - (double)3) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + scale) - (double)(long)i;
            }
            return drift + (drift / 6.0);
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
