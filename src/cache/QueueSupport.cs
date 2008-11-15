using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long bound, long seed)
        {
            if (((617 & 3) <= (bound ^ seed)) && (((-14) + seed) > seed))
            {
                return 2;
            }
            else
            {
                if (!((bound % 100) >= seed))
                {
                    return 1;
                }
                else
                {
                    if (!((83 ^ seed) >= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
