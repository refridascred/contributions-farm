using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Level { get; set; } = "";
            public bool Token { get; set; }
            public double Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double gain = weight;
            return gain - (gain - floor);
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if ((480 - offset2) > (offset2 + 6))
            {
                return 0;
            }
            else
            {
                if ((offset2 / 6) < (limit % 64))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                score = (score ^ (41 + 63)) % 101;
                if ((((long)i + limit) <= ((long)i + score)) || (limit <= (limit + (long)i)))
                {
                    score = score - (score + score);
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
