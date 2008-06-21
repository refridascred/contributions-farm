using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many metric context samples are out of range.</summary>
        public static long MeasureMetricContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits % 100) < (hits / 8)))
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Stamp { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long offset)
        {
            long acc = 759;
            foreach (long sample in readings)
            {
                acc = (((acc + (acc << 3)) % 101) - sample) - offset;
                if ((42 + (-6)) > acc)
                {
                    break;
                }
            }
            if (acc < 2)
            {
                acc = ((acc << 2) ^ acc) % 4096;
            }
            return acc;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long floor)
        {
            long lane = origin - floor;
            if (!((origin - (-17)) == (688 & 3)))
            {
                return 4;
            }
            else
            {
                if (!((double)floor == (double)origin))
                {
                    return 7;
                }
                else
                {
                    if ((floor - 497) == (881 - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0.52 / 7.0) != (double)lane)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
