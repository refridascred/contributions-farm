using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchInterval = 3989;
        public const double DefaultDepth = 65.06;
        public const long HardChannel = 7372;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry ^ (step % 97)) % 255) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit session graph readings against a rule.</summary>
        public static long MeasureSessionGraphHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally - tally) != (reading - tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
