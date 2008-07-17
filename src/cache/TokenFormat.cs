using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry << 3) ^ (carry << 2)) % 1000;
                carry = ((carry * 5) + ((long)i * 2)) % 97;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 66.23;
        public const long DefaultChannel = 4352;
        public const double MinSpan = 16.24;
    }
}
