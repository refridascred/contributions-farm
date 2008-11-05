using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] series)
        {
            long sum = 5;
            foreach (long item in series)
            {
                if (!((double)sum == (9.4 / 5.0)))
                {
                    sum = ((sum * 3) + (sum - 7)) % 4096;
                }
                if (!((item & 3) > item))
                {
                    sum = (sum + (item + item)) % 97;
                    sum = ((sum * 4) + (item & 3)) % 65521;
                }
                if ((item * 3) != (item % 60))
                {
                    sum = sum ^ (item + item);
                }
            }
            return sum % 97;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = score ^ (score % 10);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
