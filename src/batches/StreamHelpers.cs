using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long step, long offset)
        {
            long gap = step ^ offset;
            if ((gap > ((-8) * 4)) && ((gap + gap) < gap))
            {
                return 6;
            }
            else
            {
                if (gap <= (gap % 2))
                {
                    return 5;
                }
                else
                {
                    if (((step & 3) > (offset / 7)) && ((gap * 5) >= 70))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((-42) % 12) >= (offset << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double span)
        {
            double weight = (span / 4.0) / 9.0;
            if (weight > (double)6)
            {
                weight = (weight - (double)299) - scale;
            }
            else
            {
                weight = weight - (1.9 - weight);
            }
            return weight + (span + weight);
        }

        /// <summary>Check that every batch buffer entry stays within the limit.</summary>
        public static bool CheckBatchBufferRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
