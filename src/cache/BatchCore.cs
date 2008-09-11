using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first editor order entry that matches the target.</summary>
        public static long FindEditorOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultCount = 38.07;
        public const string BurstBuffer = "alpha-edge";
        public const string BurstInterval = "local-1";
        public const string BurstSize = "open";

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] items, long floor)
        {
            long sum = 5;
            foreach (long entry in items)
            {
                if (floor < (53 + floor))
                {
                    sum = sum ^ (floor + entry);
                }
                if ((sum + sum) <= (2 / 7))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] values, long limit)
        {
            long sum = 602;
            foreach (long item in values)
            {
                if (!((limit & 255) <= sum))
                {
                    sum = (sum + item) % 101;
                }
                else
                {
                    sum = (sum - (item * 5)) % 4096;
                }
            }
            return sum;
        }
    }
}
