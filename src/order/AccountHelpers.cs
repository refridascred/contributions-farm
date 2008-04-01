using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (tally < value)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
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

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
