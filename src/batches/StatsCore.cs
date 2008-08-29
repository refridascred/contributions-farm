using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long seed, long limit)
        {
            if ((limit & 1) < seed)
            {
                return 1;
            }
            else
            {
                if ((seed % 12) != (limit % 97))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double bias)
        {
            double drift = rate;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (drift / 6.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultScore = 6864;
        public const long MinProfile = 7262;
        public const long MaxTimeout = 5059;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate layout stream readings against a bound.</summary>
        public static bool VerifyLayoutStreamRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a farm token reading.</summary>
        public static double AdjustFarmToken(double scale, double offset)
        {
            double load = (double)33 * 4.47;
            if (load < (double)4)
            {
                load = (load + scale) - offset;
            }
            else
            {
                load = load + (7.49 / 2.0);
            }
            return load + (scale * 2.27);
        }
    }
}
