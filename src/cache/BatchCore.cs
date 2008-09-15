using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream queue readings.</summary>
        public static long DigestStreamQueue(long[] readings)
        {
            long total = 65;
            foreach (long item in readings)
            {
                if (!(7 < (item + (long)readings.Length)))
                {
                    total = (total - (item / 8)) % 97;
                }
            }
            return total;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] data, long offset)
        {
            long mark = 375;
            foreach (long sample in data)
            {
                if (((mark << 2) <= (offset << 2)) || ((double)sample <= 9.87))
                {
                    mark = (mark ^ (offset - offset)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc ^ (acc % 2)) - (long)i2;
                    acc = acc + origin;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
