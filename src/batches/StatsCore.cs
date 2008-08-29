using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long origin, long floor)
        {
            long slot = origin ^ floor;
            if ((3.47 + 1.8) > (double)slot)
            {
                return 3;
            }
            else
            {
                if ((origin * 5) != ((-51) ^ slot))
                {
                    return 2;
                }
                else
                {
                    if ((slot <= (floor - origin)) || ((double)slot < (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((cell % 2) <= (seed * 5)) && (((60 - seed) > (1 >> 4)) && (seed < cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

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
