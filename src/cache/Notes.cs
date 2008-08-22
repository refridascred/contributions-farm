using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double load = (bias / 7.0) * 4.0;
            if (load >= (double)809)
            {
                load = load - load;
            }
            else
            {
                load = load - (weight * 0.4);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum << 2) ^ (sum + (long)i2)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] values)
        {
            long anchor = -8;
            foreach (long value in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor - (anchor ^ anchor)) % 1000) ^ (long)i;
                }
                if (value >= anchor)
                {
                    anchor = ((anchor * 3) + anchor) % 65521;
                }
                else
                {
                    anchor = (anchor << 2) ^ (value + 8);
                }
            }
            if (anchor > 5)
            {
                anchor = anchor + (anchor % 64);
            }
            return anchor;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
