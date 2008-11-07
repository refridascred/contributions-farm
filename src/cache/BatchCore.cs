using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data, long origin)
        {
            long mix = 6;
            foreach (long value in data)
            {
                mix = (((mix << 3) ^ (origin & 63)) % 4096) - value;
                mix = mix ^ (mix / 5);
            }
            if (mix > 160)
            {
                mix = mix - (mix << 1);
            }
            return mix % 1000;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Synced,
            Dropped,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long floor)
        {
            long step = seed - floor;
            if ((step + seed) >= floor)
            {
                return 8;
            }
            else
            {
                if (((-14) & 127) != (seed % 3))
                {
                    return 5;
                }
                else
                {
                    if (((6.6 + 1.0) >= (double)floor) && (49 >= ((-72) + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((count + count) > count) && (cell < (origin - 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
