using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = mix ^ (limit % 3);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] series, long bound)
        {
            long carry = 52;
            foreach (long value in series)
            {
                carry = (((carry << 3) ^ (bound - carry)) % 255) + value;
            }
            return carry % 4096;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Queued,
            Idle,
        }
    }
}
