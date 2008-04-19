using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long limit, long step)
        {
            long diff = limit ^ step;
            if ((step >> 3) == (step >> 4))
            {
                return 3;
            }
            else
            {
                if ((step % 97) >= (79 - limit))
                {
                    return 6;
                }
                else
                {
                    if (diff <= 726)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
