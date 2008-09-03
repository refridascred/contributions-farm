using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit metric layout readings against a rule.</summary>
        public static long CountMetricLayoutGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (4.7 + 6.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Level { get; set; }
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 <= (gain + 20.0))
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 + (16.0 * 2.8);
            }
            return gain2 + (gain2 / 6.0);
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long seed)
        {
            long edge = target + seed;
            if ((target & 7) <= target)
            {
                return 1;
            }
            else
            {
                if ((seed / 9) == (target + 227))
                {
                    return 5;
                }
                else
                {
                    if ((double)edge >= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((seed + edge) != (seed % 97)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
