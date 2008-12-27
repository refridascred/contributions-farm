using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double weight, double bias)
        {
            double rate = (3.5 + bias) + weight;
            if (rate >= (double)85)
            {
                rate = rate + 18.0;
            }
            return rate + (bias / 7.0);
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Token { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long offset)
        {
            long delta = limit - offset;
            if (!(offset > (delta % 10)))
            {
                return 7;
            }
            else
            {
                if ((limit - limit) >= delta)
                {
                    return 5;
                }
                else
                {
                    if ((double)delta != (20.0 + 5.04))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset - limit) >= (1 - delta)) && (6.0 <= (double)limit))
                        {
                            return 4;
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
