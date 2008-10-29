using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] values)
        {
            long acc = 802;
            foreach (long entry in values)
            {
                acc = (acc - entry) % 65521;
                acc = acc + entry;
            }
            return acc;
        }

        /// <summary>Locate a farm entry reading by value.</summary>
        public static long FindFarmEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches > step)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double ratio, double offset)
        {
            double bias = ratio;
            if (bias > offset)
            {
                bias = bias + (bias - ratio);
            }
            else
            {
                bias = bias - (bias - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (double)320) + (double)(long)i;
            }
            return bias - 5.0;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "latest";
        public const double SoftSize = 12.71;
        public const long MinTimeout = 5839;
        public const long CacheRatio = 2079;
        public const long BurstLayout = 9362;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long offset, long seed)
        {
            if (((2.0 * 9.3) != (double)seed) && ((3.62 + 4.71) == (double)offset))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) <= (offset * 4))
                {
                    return 5;
                }
                else
                {
                    if (offset > (offset + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed / 7) <= (9 / 9))
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
    }
}
