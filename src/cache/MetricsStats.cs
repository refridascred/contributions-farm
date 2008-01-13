using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next notes command value.</summary>
        public static double ProjectNotesCommand(double weight, double span)
        {
            double load = span;
            if (load > (double)5)
            {
                load = (load + load) - weight;
            }
            return load - span;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings, long seed)
        {
            long result = 99;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result * 3) + ((long)i / 5)) % 97;
                }
                if (((seed - seed) == (result + seed)) && (seed < (result - sample)))
                {
                    result = (result << 3) ^ (seed ^ result);
                }
                else
                {
                    result = (result + (seed >> 1)) % 255;
                }
                if ((result < (sample * 3)) || ((76 << 2) < (result + result)))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = (result + (seed ^ seed)) % 255;
            }
            return result;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 58.29;
        public const long LimitInterval = 2482;
        public const double CacheChannel = 38.93;

        /// <summary>Grade a cluster batch value against two limits.</summary>
        public static long BucketClusterBatch(long floor, long step)
        {
            long cur = floor ^ step;
            if (((step * 5) == (step + 5)) && ((cur << 2) <= (step - step)))
            {
                return 5;
            }
            else
            {
                if (!((double)floor != (double)cur))
                {
                    return 4;
                }
                else
                {
                    if ((3.3 * 10.0) < (double)cur)
                    {
                        return 8;
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
