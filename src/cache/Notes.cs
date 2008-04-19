using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long limit2)
        {
            long delta = limit - limit2;
            if (((limit2 + limit) != (delta + limit)) || ((61 * 3) > delta))
            {
                return 8;
            }
            else
            {
                if ((double)limit <= (16.0 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((606 * 3) <= (delta & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit2 > limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double rate = (double)4 - scale;
            return rate - floor;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long origin)
        {
            long prev = seed ^ origin;
            if (((seed % 60) < seed) && ((origin * 5) <= (origin - prev)))
            {
                return 4;
            }
            else
            {
                if ((seed * 5) < (prev << 1))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
