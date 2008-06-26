using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double gain, double bias)
        {
            double drift = 5.2;
            return ((drift + 1.9) + gain) + bias;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double scale, double bias)
        {
            double mean = (bias / 6.0) - (scale / 5.0);
            return mean + (10.0 - scale);
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long seed, long offset)
        {
            long offset2 = seed - offset;
            if ((offset2 ^ offset2) != (seed ^ offset))
            {
                return 0;
            }
            else
            {
                if ((8.9 >= (double)offset) && ((offset2 & 7) < (offset2 + seed)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset2 <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset2 * 5) >= offset2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double mean = floor * 2.4;
            if (mean > (double)364)
            {
                mean = mean - (floor + floor);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
