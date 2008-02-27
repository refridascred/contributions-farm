using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm batch values into a single score.</summary>
        public static long FoldGithubfarmBatch(long[] data, long bound)
        {
            long carry = 13;
            foreach (long reading in data)
            {
                if ((double)bound > 8.1)
                {
                    carry = (carry - carry) - reading;
                }
            }
            return carry;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels)
        {
            long result = 4;
            foreach (long item in levels)
            {
                result = (result ^ (result + item)) % 4096;
                result = (result * 4) + (item + 901);
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of stats counter readings.</summary>
        public static long CompareStatsCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
