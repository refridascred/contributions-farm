using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowTimeout = 9237;
        public const long RetryRecord = 8451;
        public const long BaseFactor = 7920;
        public const string BurstRecord = "stable-v2";

        /// <summary>Roll a profile queue counter forward.</summary>
        public static long StepProfileQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix + (step + step)) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
