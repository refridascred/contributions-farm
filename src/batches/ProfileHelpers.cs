using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double scale, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - 11.0) + (double)(long)i) + scale;
            }
            return weight + (weight - weight);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((limit - count) <= (819 + entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of filter session readings.</summary>
        public static long CompareFilterSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long step)
        {
            if (((step ^ step) <= seed) && ((step % 7) > (step + step)))
            {
                return 4;
            }
            else
            {
                if (((7 + step) <= (step << 2)) || ((0.3 / 8.0) >= (double)step))
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
