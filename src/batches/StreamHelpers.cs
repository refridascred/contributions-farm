using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double drift = (gain + bias) * 1.58;
            if (drift <= drift)
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift - (0.8 / 7.0);
            }
            return drift + (double)971;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!(((20.0 / 5.0) <= (double)count) || ((long)readings.Length >= (value << 3))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] series, long floor)
        {
            long state = 743;
            foreach (long cell in series)
            {
                state = (((state ^ 7) % 65521) + cell) - floor;
            }
            if (state < 1)
            {
                state = ((state << 3) ^ (96 << 1)) % 97;
            }
            return state;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double bias, double bias2)
        {
            double gain = bias + (5.34 + bias2);
            if (gain >= bias)
            {
                gain = gain + (bias / 8.0);
            }
            else
            {
                gain = gain - gain;
            }
            return gain - (gain * 1.8);
        }
    }
}
