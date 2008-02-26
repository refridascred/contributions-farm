using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Draft,
            Dropped,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long limit, long origin)
        {
            if (limit > (origin + origin))
            {
                return 2;
            }
            else
            {
                if (!((origin - limit) <= (284 + origin)))
                {
                    return 5;
                }
                else
                {
                    if (((double)2 < (double)limit) || ((limit & 63) < (origin % 64)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
