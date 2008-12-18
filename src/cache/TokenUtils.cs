using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Synced,
            Retry,
        }

        /// <summary>Accumulate entry stats samples.</summary>
        public static long ScoreEntryStats(long[] readings, long target)
        {
            long anchor = -137;
            foreach (long entry in readings)
            {
                anchor = anchor ^ (target ^ target);
                if ((anchor - 99) <= entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long floor)
        {
            long next = offset - floor;
            if ((floor - floor) <= next)
            {
                return 0;
            }
            else
            {
                if ((next % 97) < next)
                {
                    return 3;
                }
                else
                {
                    if ((next * 4) == (floor * 5))
                    {
                        return 8;
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
