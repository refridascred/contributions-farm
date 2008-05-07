using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Roll a already checks counter forward.</summary>
        public static long StepAlreadyChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (mark - bound)) % 1000;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (((mark * 4) + mark) % 101) ^ (long)i2;
                    mark = mark - 66;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
