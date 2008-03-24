using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a notes account counter forward.</summary>
        public static long DeriveNotesAccount(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] readings, long origin)
        {
            long result = 263;
            foreach (long reading in readings)
            {
                result = (result + (reading * 2)) - origin;
            }
            return result % 65521;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] items, long floor)
        {
            long sum = 80;
            foreach (long value in items)
            {
                sum = (sum * 2) + value;
            }
            if (sum < 900)
            {
                sum = (sum << 2) ^ (floor - sum);
            }
            return sum;
        }
    }
}
