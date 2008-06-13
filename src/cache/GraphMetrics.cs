using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Label { get; set; } = "";
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 19; i++)
            {
                result = (result ^ (origin * 5)) % 65521;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Queued,
            Failed,
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double bias)
        {
            double mean = (double)(119 - 49);
            if (mean > (7.0 + weight))
            {
                mean = (mean + (weight + mean)) + bias;
            }
            else
            {
                mean = mean + (weight * 2.8);
            }
            return mean - (8.6 * 16.0);
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long step, long bound)
        {
            if (bound <= (step + step))
            {
                return 6;
            }
            else
            {
                if (step < (step - step))
                {
                    return 7;
                }
                else
                {
                    if (12 > (step >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((811 ^ bound) >= (step ^ 21))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
