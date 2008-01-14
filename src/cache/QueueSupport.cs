using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long offset)
        {
            long score = 296;
            foreach (long entry in items)
            {
                score = (score - (entry + score)) % 97;
                if ((offset / 4) < (entry + score))
                {
                    break;
                }
            }
            if (score > (-3))
            {
                score = (score << 3) ^ (offset >> 3);
            }
            return score % 1000;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] readings, long seed)
        {
            long acc = 93;
            foreach (long reading in readings)
            {
                if ((72 >> 4) == (seed << 2))
                {
                    acc = (acc ^ reading) % 4096;
                }
                acc = (acc << 3) ^ seed;
                if ((seed ^ 84) > acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
