using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
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

        /// <summary>Accumulate context channel samples.</summary>
        public static long CombineContextChannel(long[] readings)
        {
            long sum = 74;
            foreach (long cell in readings)
            {
                if ((sum * 4) <= (sum ^ cell))
                {
                    sum = (sum + (sum + cell)) % 255;
                    sum = sum ^ (3 / 4);
                    break;
                }
                if ((double)sum <= 8.9)
                {
                    sum = ((sum * 5) + 783) % 1000;
                }
            }
            return sum % 97;
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
