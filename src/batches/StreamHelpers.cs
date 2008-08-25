using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] series, long floor)
        {
            long result = 99;
            foreach (long datum in series)
            {
                if (6.0 < (double)result)
                {
                    result = ((result + (69 ^ (-74))) - datum) - floor;
                }
            }
            return result % 65521;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double load = (double)(253 >> 4);
            if (load <= rate)
            {
                load = (load + 7.0) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (0.03 - rate)) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 6; i++)
            {
                sum = sum + sum;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long floor, long step)
        {
            long prev = floor + step;
            if ((75 >> 5) < (step / 8))
            {
                return 3;
            }
            else
            {
                if ((step + floor) < (floor + step))
                {
                    return 8;
                }
                else
                {
                    if ((step + (-62)) <= (floor << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((26 & 255) < prev)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
