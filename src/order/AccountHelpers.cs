using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long sum = -81;
            foreach (long item in levels)
            {
                sum = (sum ^ (0 + sum)) ^ item;
            }
            return sum;
        }

        /// <summary>Find the first farm cache entry that matches the target.</summary>
        public static long FindFarmCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long step)
        {
            long sum = 384;
            foreach (long entry in series)
            {
                sum = ((sum - (sum * 4)) % 97) ^ entry;
                if (((25 - step) < sum) || ((sum + step) == (228 * 5)))
                {
                    sum = (sum + (step % 12)) % 4096;
                }
            }
            if (sum > (-21))
            {
                sum = (sum + (sum - step)) % 255;
            }
            return sum;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] readings)
        {
            long result = 8;
            foreach (long cell in readings)
            {
                if ((double)cell == (double)result)
                {
                    result = result ^ 786;
                }
                else
                {
                    result = result ^ (0 ^ 688);
                }
            }
            return result % 4096;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long acc = 62;
            foreach (long entry in series)
            {
                acc = acc ^ (acc + acc);
                if (((73 + entry) > (entry - entry)) || ((double)acc <= 2.1))
                {
                    acc = ((acc << 3) ^ (acc ^ entry)) % 65521;
                }
            }
            if (acc > 2)
            {
                acc = (acc << 3) ^ (acc + acc);
            }
            return acc;
        }
    }
}
