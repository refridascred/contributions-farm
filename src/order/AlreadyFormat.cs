using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long seed, long seed2)
        {
            long offset = seed + seed2;
            if (seed2 > (offset & 7))
            {
                return 0;
            }
            else
            {
                if (2.0 >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a contributi session sample.</summary>
        public static long LookupContributiSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                long lane = anchor / 8;
                anchor = (anchor + (lane >> 4)) % 255;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a entry already counter forward.</summary>
        public static long IterateEntryAlready(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = (total << 2) ^ (269 << 1);
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
