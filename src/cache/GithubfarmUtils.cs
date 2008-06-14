using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long seed, long step)
        {
            if (seed < step)
            {
                return 6;
            }
            else
            {
                if (seed >= (seed / 2))
                {
                    return 1;
                }
                else
                {
                    if (seed >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - 27) >= (seed + 560))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] items, long limit)
        {
            long acc = 5;
            foreach (long reading in items)
            {
                if ((limit * 4) == (acc % 24))
                {
                    acc = (acc << 2) ^ (reading & 15);
                    acc = (acc - limit) % 4096;
                    break;
                }
                acc = (acc << 2) ^ (limit & 15);
                acc = (acc * 3) + (reading + 1);
            }
            if (acc < 52)
            {
                acc = (acc ^ (acc + (-234))) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = total - total;
                total = (total - 1) % 97;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
