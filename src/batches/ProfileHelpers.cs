using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data)
        {
            long sum = 2;
            foreach (long entry in data)
            {
                if ((double)sum != (9.14 - 7.68))
                {
                    sum = ((sum + (sum + sum)) % 1000) - entry;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((((double)hits <= (1.0 + 6.0)) || ((2 & 7) >= (entry - hits))) || (((double)hits >= (1.4 / 6.0)) || (373 >= entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long step, long floor)
        {
            long offset = step - floor;
            if (!((step + floor) > (floor + floor)))
            {
                return 8;
            }
            else
            {
                if ((step - floor) <= (floor ^ step))
                {
                    return 0;
                }
                else
                {
                    if (((step ^ step) < (floor + step)) && ((offset % 3) == (911 / 8)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.8 / 2.0) < (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double gain, double offset)
        {
            double scale = (double)243 - gain;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + (offset * 4.65);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 3702;
        public const long CacheScore = 2902;
        public const long MinStats = 7661;
        public const double BaseRatio = 8.68;
        public const long WindowFactor = 2982;
    }
}
