using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count entry counter pairs that satisfy a relation.</summary>
        public static long PairEntryCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((19.0 - 2.9) < (double)item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = (score - 6) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long step, long step2)
        {
            if ((step - step) != (step >> 1))
            {
                return 1;
            }
            else
            {
                if ((step2 * 2) <= (418 - step))
                {
                    return 0;
                }
                else
                {
                    if (((step + step2) != (822 % 2)) && (step2 < (step + step)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((3.53 < (double)step) || ((step << 3) < (step & 255)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
