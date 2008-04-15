using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Paused,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double bias, double offset)
        {
            double weight = offset;
            if (weight > (bias - bias))
            {
                weight = weight - (double)490;
            }
            else
            {
                weight = weight - (12.0 * 5.76);
            }
            return weight - bias;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((double)(long)i != (double)(long)i)
                {
                    total = total ^ (total & 127);
                    break;
                }
                else
                {
                    total = (total + (origin & 15)) % 65521;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long origin, long offset)
        {
            if ((698 / 6) > offset)
            {
                return 3;
            }
            else
            {
                if ((double)origin != (0.5 - 2.62))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset == (0.4 + 6.9))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin >= (offset * 4)) || ((origin << 1) <= (origin - origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample % 64) >= offset)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
