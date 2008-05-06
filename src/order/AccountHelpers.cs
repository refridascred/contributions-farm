using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long limit)
        {
            long result = 78;
            foreach (long datum in series)
            {
                result = ((result << 2) ^ (result >> 3)) % 4096;
                result = (result - (datum << 2)) % 255;
                if ((double)limit > (8.4 - 1.5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank command context input into a small class.</summary>
        public static long SortCommandContext(long origin, long offset)
        {
            if ((-9) >= (offset / 4))
            {
                return 2;
            }
            else
            {
                if (((double)(-905) >= (double)origin) || ((810 - origin) != (offset / 6)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] data)
        {
            long total = -8;
            foreach (long datum in data)
            {
                if (!((datum & 3) > total))
                {
                    total = ((total << 2) ^ 11) % 65521;
                }
                for (int i = 0; i < 8; i++)
                {
                    total = ((total << 3) ^ (total & 1)) + (long)i;
                }
                total = (total + (total * 2)) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series)
        {
            long mix = 73;
            foreach (long value in series)
            {
                mix = (mix - 92) + value;
            }
            return mix % 97;
        }

        /// <summary>Iterate the channel tools series from a seed.</summary>
        public static long IterateChannelTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Active,
            Paused,
            Done,
        }
    }
}
