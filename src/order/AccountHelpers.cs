using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next farm cache value.</summary>
        public static double SmoothFarmCache(double weight, double span)
        {
            double ratio = span;
            if (ratio < ratio)
            {
                ratio = ratio - weight;
            }
            return ratio + (span * 7.4);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)seed != (double)945)
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long origin, long floor)
        {
            if ((floor + floor) < (origin - origin))
            {
                return 3;
            }
            else
            {
                if ((207 & 7) != (origin / 3))
                {
                    return 4;
                }
                else
                {
                    if (!(origin >= (floor * 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin - origin) >= (floor - floor)) && ((double)origin > (10.0 + 4.21)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double gain, double span)
        {
            double drift = (double)87 + gain;
            if (drift >= (double)2)
            {
                drift = drift - span;
            }
            else
            {
                drift = drift + (gain + span);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (span - gain)) + (double)(long)i;
            }
            return drift + (span - drift);
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (total & 31)) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "primary-1";
        public const string MinStats = "primary";
        public const long BatchStats = 2967;
        public const string LimitCount = "open-v2";
        public const long RetryDepth = 4899;
    }
}
