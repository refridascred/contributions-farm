using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long origin)
        {
            long next = offset + origin;
            if ((next <= (offset / 6)) && ((offset ^ next) <= (next << 1)))
            {
                return 1;
            }
            else
            {
                if ((84 + offset) == (offset >> 4))
                {
                    return 2;
                }
                else
                {
                    if ((17.0 + 1.0) <= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((next ^ origin) < next) && ((9 * 5) == (origin % 100)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two layout context measurements.</summary>
        public static double ProjectLayoutContext(double rate, double floor)
        {
            double ratio = rate;
            if (ratio <= (double)(-27))
            {
                ratio = (ratio - (rate * 2.0)) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (rate - rate)) + (double)(long)i;
            }
            return ratio - (ratio / 7.0);
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double gain = scale * 1.0;
            if (gain > (double)22)
            {
                gain = gain - (3.46 - span);
            }
            else
            {
                gain = gain - 8.0;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (span - scale);
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels)
        {
            long score = 908;
            foreach (long cell in levels)
            {
                score = ((score - score) % 4096) + cell;
            }
            return score;
        }
    }
}
