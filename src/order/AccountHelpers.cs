using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitLevel = 20.48;
        public const string BurstFarm = "stable-edge";
        public const string RetryFarm = "stable";

        /// <summary>Check that every graph tools entry stays within the limit.</summary>
        public static bool CheckGraphToolsLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFactor = "cached-v2";
        public const double BaseFilter = 16.18;
        public const long MaxFilter = 8935;

        /// <summary>Rank record route input into a small class.</summary>
        public static long BucketRecordRoute(long limit, long floor)
        {
            long diff = limit + floor;
            if (((-2) - diff) >= (limit / 3))
            {
                return 5;
            }
            else
            {
                if ((diff + diff) > limit)
                {
                    return 1;
                }
                else
                {
                    if (((15.0 + 6.79) >= (double)limit) && ((diff << 3) < floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3.63 / 5.0) > (double)limit)
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

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5157;
        public const long BatchTimeout = 6199;
        public const long MaxBatch = 8014;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (limit <= (entry / 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
