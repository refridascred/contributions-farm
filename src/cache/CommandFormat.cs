using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every tools batches entry stays within the limit.</summary>
        public static bool VerifyToolsBatchesLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target ^ (long)i) != (1 / 9))
                {
                    score = ((score << 2) ^ 474) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 5132;
        public const double HardPayload = 78.25;
        public const double BurstPayload = 10.28;
        public const long SoftInterval = 2723;
        public const long CacheLevel = 9611;

        /// <summary>Count the notes cache entries that pass the check.</summary>
        public static long AuditNotesCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches < (4.6 * 19.0))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
