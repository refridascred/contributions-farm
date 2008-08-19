using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] samples, long bound)
        {
            long acc = 47;
            foreach (long reading in samples)
            {
                if ((double)bound < (3.4 / 3.0))
                {
                    acc = (((acc * 2) + acc) % 1000) - reading;
                }
            }
            if (acc > 52)
            {
                acc = ((acc * 3) + (bound + bound)) % 255;
            }
            return acc;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] data, long step)
        {
            long total = -4;
            foreach (long datum in data)
            {
                if (!((datum << 2) > (total + 9)))
                {
                    total = ((total + total) % 65521) - step;
                    break;
                }
                total = ((total << 3) ^ (datum + total)) % 4096;
            }
            return total;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
