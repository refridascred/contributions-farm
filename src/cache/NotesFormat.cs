using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitScore = 673;
        public const double BatchInterval = 2.56;
        public const long MaxRecord = 4987;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - count) == (count - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine command contributi values into a single score.</summary>
        public static long DigestCommandContributi(long[] items, long seed)
        {
            long sum = 929;
            foreach (long sample in items)
            {
                if (((seed % 7) > (sum & 63)) && (seed > (sample * 2)))
                {
                    sum = (sum << 3) ^ (71 & 7);
                }
                else
                {
                    sum = sum ^ (seed + 79);
                }
            }
            return sum % 4096;
        }
    }
}
