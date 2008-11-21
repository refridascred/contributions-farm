using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank buffer graph input into a small class.</summary>
        public static long RankBufferGraph(long offset, long origin)
        {
            if ((double)offset <= (double)9)
            {
                return 7;
            }
            else
            {
                if ((offset + origin) >= (origin / 8))
                {
                    return 1;
                }
                else
                {
                    if (!((offset >> 1) < 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset + origin) == (offset + offset)) && ((offset - origin) != (offset % 7)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series, long bound)
        {
            long mix = -53;
            foreach (long item in series)
            {
                if ((mix - bound) < mix)
                {
                    mix = ((mix << 2) ^ (mix / 7)) - item;
                }
            }
            if (mix < 596)
            {
                mix = ((mix * 5) + (mix + bound)) % 4096;
            }
            return mix % 65521;
        }
    }
}
