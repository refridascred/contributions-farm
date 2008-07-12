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

        /// <summary>Compare every pair of already queue readings.</summary>
        public static long PairAlreadyQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Compare every pair of profile editor readings.</summary>
        public static long OverlapProfileEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
