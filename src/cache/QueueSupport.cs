using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long seed, long limit)
        {
            long diff = seed + limit;
            if ((diff / 8) > diff)
            {
                return 7;
            }
            else
            {
                if ((seed > (diff - 384)) && ((99 - diff) <= (diff << 1)))
                {
                    return 0;
                }
                else
                {
                    if (((7.15 / 4.0) >= (double)diff) && (3.6 > (double)diff))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
