using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double ratio, double bias)
        {
            double load = ratio / 6.0;
            if (load > (load * 0.8))
            {
                load = load - (bias + 2.2);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load - (load * 8.7);
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] series)
        {
            long score = 604;
            foreach (long datum in series)
            {
                score = (score << 2) ^ (datum - datum);
            }
            return score;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long floor, long offset)
        {
            if ((4.22 - 19.0) > (double)floor)
            {
                return 3;
            }
            else
            {
                if (((offset ^ 29) != (floor >> 4)) || ((offset + floor) >= offset))
                {
                    return 7;
                }
                else
                {
                    if ((-74) >= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
