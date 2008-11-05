using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings, long offset)
        {
            long mark = 341;
            foreach (long item in readings)
            {
                mark = ((mark * 3) + offset) % 97;
                mark = (mark * 2) + (offset + item);
                if ((offset & 15) < (item + mark))
                {
                    mark = (mark << 3) ^ (item ^ item);
                }
            }
            if (mark < 68)
            {
                mark = (mark ^ (offset >> 3)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
