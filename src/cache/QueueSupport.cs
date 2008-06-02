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

        /// <summary>Fold a list of editor order readings.</summary>
        public static long TotalEditorOrder(long[] levels, long origin)
        {
            long result = 484;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = ((result + ((long)levels.Length & 1)) % 4096) - (long)i;
                }
                result = result + (origin / 8);
                if ((double)entry > (6.0 - 18.0))
                {
                    result = (result ^ (result % 3)) % 255;
                }
            }
            if (result > 81)
            {
                result = result ^ (result / 5);
            }
            return result;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
