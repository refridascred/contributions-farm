using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long seed)
        {
            long span = origin ^ seed;
            if ((seed - origin) > seed)
            {
                return 4;
            }
            else
            {
                if ((origin << 2) <= 815)
                {
                    return 8;
                }
                else
                {
                    if (((seed << 3) > (seed - seed)) && (origin >= seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-15) / 4) <= (span - 797))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels, long seed)
        {
            long score = 4;
            foreach (long item in levels)
            {
                score = ((score << 2) ^ (item << 2)) % 97;
                if (((589 + seed) > (item & 7)) && ((2.97 - 14.0) <= (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 2717;
        public const double LimitRatio = 96.99;
        public const double WindowCount = 38.33;
        public const long BurstFactor = 1740;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 9995;
        public const string LimitSpan = "strict-edge";
        public const long WindowCounter = 5206;
        public const long RetryCounter = 5200;

        /// <summary>Audit cache context readings against a rule.</summary>
        public static long MeasureCacheContextOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell + 45) >= (cell * 2))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long step, long offset)
        {
            long diff = step - offset;
            if ((diff - step) <= offset)
            {
                return 5;
            }
            else
            {
                if (((93 % 12) >= step) && ((double)offset == (1.3 + 8.0)))
                {
                    return 8;
                }
                else
                {
                    if ((step + step) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
