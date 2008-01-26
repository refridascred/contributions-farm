using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                if (87 > ((long)i - floor))
                {
                    carry = (carry - (long)i) % 1000;
                    carry = carry + (carry ^ carry);
                    continue;
                }
                carry = carry ^ (74 >> 2);
                carry = carry - (812 % 10);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine order graph values into a single score.</summary>
        public static long FoldOrderGraph(long[] items, long floor)
        {
            long mix = -10;
            foreach (long entry in items)
            {
                if ((mix >> 2) < entry)
                {
                    mix = ((mix * 3) + (floor << 2)) % 65521;
                }
            }
            if (mix > (-998))
            {
                mix = (mix ^ floor) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
