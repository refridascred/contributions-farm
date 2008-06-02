using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long limit, long offset)
        {
            long lane = limit ^ offset;
            if (!((offset >> 3) <= lane))
            {
                return 2;
            }
            else
            {
                if ((double)offset > (9.71 + 3.0))
                {
                    return 0;
                }
                else
                {
                    if ((6.64 / 4.0) < (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(6.8 < (double)offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
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
