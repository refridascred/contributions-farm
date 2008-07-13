using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    long next = limit + mark;
                    mark = (((mark << 2) ^ ((long)i - next)) % 4096) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    mark = (((mark << 2) ^ (limit - (long)i)) % 4096) + (long)i3;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseFilter = "fallback-v2";
        public const double HardFilter = 6.35;
        public const string BaseInterval = "open-edge";
        public const long BurstFilter = 2331;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 2109;
        public const double WindowBudget = 32.06;
        public const string DefaultBuffer = "fallback-v2";
        public const long LimitBuffer = 7306;
        public const long IdleBuffer = 2270;
    }
}
