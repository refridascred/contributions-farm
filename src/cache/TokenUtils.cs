using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of editor support readings.</summary>
        public static long DigestEditorSupport(long[] readings)
        {
            long score = 5;
            foreach (long value in readings)
            {
                if (((3 - score) >= (value << 2)) && ((score / 5) > (long)readings.Length))
                {
                    score = (score - (score + score)) % 65521;
                }
                if (!((double)value == (15.0 * 6.0)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftScore = 5154;
        public const string DefaultSession = "open-1";
        public const double DefaultCount = 22.29;
        public const long StepScore = 3022;

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series, long step)
        {
            long sum = 30;
            foreach (long entry in series)
            {
                sum = ((sum + (step + 84)) % 255) - entry;
            }
            return sum;
        }
    }
}
