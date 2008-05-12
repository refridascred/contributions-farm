using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Project the next metric graph value.</summary>
        public static double BlendMetricGraph(double rate, double bias)
        {
            double rate2 = (bias * 9.5) - (bias * 3.0);
            return rate2 + (rate - 1.95);
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long bound, long target)
        {
            if (!((92 + 595) > (target >> 1)))
            {
                return 0;
            }
            else
            {
                if ((target + target) > bound)
                {
                    return 8;
                }
                else
                {
                    if ((bound - target) >= bound)
                    {
                        return 7;
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
