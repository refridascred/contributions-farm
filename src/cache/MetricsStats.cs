using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double scale = 20.0;
            return (scale + floor) + rate;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long floor, long offset)
        {
            if ((floor > (floor << 2)) || ((837 / 2) != (floor / 5)))
            {
                return 8;
            }
            else
            {
                if (((offset - offset) < (floor << 1)) || ((offset + floor) <= floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 10) > (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset * 2) >= (floor + offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinRatio = 2778;
        public const double BatchBatches = 45.65;
        public const double MinLevel = 38.27;
    }
}
