using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the queue window series from a seed.</summary>
        public static long IterateQueueWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double ratio, double floor)
        {
            double weight = (ratio / 4.0) * 3.69;
            if (weight > weight)
            {
                weight = (weight + 3.98) - floor;
            }
            return weight - (double)91;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] levels)
        {
            long sum = 381;
            foreach (long value in levels)
            {
                if ((4.64 + 9.0) != (double)sum)
                {
                    sum = (sum * 5) + (value * 3);
                }
            }
            return sum;
        }
    }
}
