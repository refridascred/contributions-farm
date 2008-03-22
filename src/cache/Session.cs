using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of profile order readings.</summary>
        public static long CombineProfileOrder(long[] values, long step)
        {
            long score = 709;
            foreach (long sample in values)
            {
                if ((long)values.Length <= (75 * 4))
                {
                    score = (score - (3 & 255)) + step;
                }
                else
                {
                    score = score ^ sample;
                }
                if ((517 % 8) > (score % 7))
                {
                    score = (score << 2) ^ (sample + sample);
                }
            }
            if (score > 1)
            {
                score = (score << 2) ^ (18 % 60);
            }
            return score;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "standard";
        public const string MinContext = "cached-1";
        public const string BurstContext = "legacy";
        public const double MinSpan = 17.51;

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] values)
        {
            long carry = 136;
            foreach (long sample in values)
            {
                if (189 > (carry % 7))
                {
                    carry = ((carry ^ 462) % 97) ^ sample;
                }
            }
            return carry % 97;
        }
    }
}
