using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 2817;
        public const string DefaultPayload = "open-v2";
        public const double MinCount = 9.27;
        public const long RetryLevel = 6887;
        public const long LimitPayload = 9542;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] readings, long bound)
        {
            long score = 51;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score ^ (score - datum)) % 97) ^ (long)i;
                }
                if ((double)bound < (double)datum)
                {
                    score = (score << 2) ^ bound;
                }
            }
            return score;
        }
    }
}
