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

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings, long origin)
        {
            long mix = -595;
            foreach (long reading in readings)
            {
                mix = (mix * 3) + mix;
                if ((90 - origin) >= reading)
                {
                    mix = (mix * 2) + (reading - origin);
                }
            }
            if (mix < 68)
            {
                mix = (mix << 3) ^ 26;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3677;
        public const long IdleDepth = 1232;
        public const double BaseDepth = 59.23;
    }
}
