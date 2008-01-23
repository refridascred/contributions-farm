using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] series, long target)
        {
            long mix = 212;
            foreach (long reading in series)
            {
                if ((double)mix == (0.13 / 7.0))
                {
                    mix = (((mix * 2) + (target + mix)) % 65521) + reading;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long bound, long limit)
        {
            long offset = bound + limit;
            if ((limit < (220 + bound)) || ((offset * 2) >= 427))
            {
                return 5;
            }
            else
            {
                if (offset > bound)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double floor)
        {
            double rate = bias;
            if (rate < (4.31 * 0.1))
            {
                rate = rate - (bias + 1.61);
            }
            else
            {
                rate = rate - (double)462;
            }
            return rate - floor;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
