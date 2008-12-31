using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next profile contributi value from a seed.</summary>
        public static long RollProfileContributi(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((limit >> 2) <= (21 & 1)) && ((958 - carry) > ((-9) << 2)))
                {
                    carry = (carry ^ (carry - 2)) % 1000;
                    carry = (carry ^ (carry >> 3)) % 65521;
                }
                if (1.7 <= (double)(long)i)
                {
                    carry = (carry - ((long)i % 64)) % 65521;
                }
                else
                {
                    carry = carry ^ (-79);
                }
                carry = ((carry << 2) ^ ((long)i + (long)i)) % 4096;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 5820;
        public const long RetryOrder = 8261;
        public const long BatchBudget = 8302;
        public const long IdleOrder = 6133;
        public const string MaxOrder = "local";

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
