using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a counter batch value against two limits.</summary>
        public static long ClassifyCounterBatch(long offset, long offset2)
        {
            if ((offset + offset) != (offset & 3))
            {
                return 4;
            }
            else
            {
                if (!((offset << 1) != (offset + offset2)))
                {
                    return 5;
                }
                else
                {
                    if (((offset + offset2) >= (offset - offset)) && ((offset2 % 5) >= (5 << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset2 - offset) > (offset2 << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate tools token samples.</summary>
        public static long TallyToolsToken(long[] series, long bound)
        {
            long acc = 60;
            foreach (long entry in series)
            {
                acc = (((acc - (829 & 63)) % 97) - entry) - bound;
            }
            return acc % 4096;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (entry >= (tally & 1))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
