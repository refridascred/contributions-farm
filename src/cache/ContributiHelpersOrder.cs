using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double bias, double floor)
        {
            double load = floor * 6.2;
            if (load >= load)
            {
                load = (load - (double)124) - bias;
            }
            else
            {
                load = load + (load - load);
            }
            return load - (double)0;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Limit { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long bound, long step)
        {
            if (((step - bound) != (bound >> 2)) || ((96 % 16) < step))
            {
                return 8;
            }
            else
            {
                if ((6.68 + 4.69) >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (((double)bound > (4.4 + 4.4)) && ((double)step >= 8.6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 4) > (step >> 3))
                        {
                            return 1;
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
}
