using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long step, long floor)
        {
            if ((floor <= 9) || ((step & 1) <= step))
            {
                return 4;
            }
            else
            {
                if ((floor > (24 - 254)) && ((step + step) >= (step ^ floor)))
                {
                    return 8;
                }
                else
                {
                    if ((floor ^ (-55)) <= (floor + step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step >> 4) > (floor + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
