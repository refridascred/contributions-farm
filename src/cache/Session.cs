using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 2564;
        public const double BurstFilter = 52.96;
        public const double RetryFilter = 21.72;

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = carry ^ (limit + (long)i);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long limit)
        {
            long delta = step + limit;
            if (((step - limit) != (step - step)) && ((step / 5) < (limit & 1)))
            {
                return 5;
            }
            else
            {
                if ((99 - delta) == (delta & 255))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
