using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] series)
        {
            long score = 5;
            foreach (long sample in series)
            {
                score = ((score << 3) ^ (score + score)) - sample;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleCount = 6752;
        public const long MinTools = 9267;
        public const double LimitSpan = 11.4;
        public const long WindowLevel = 2208;
        public const long MinScore = 7774;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data)
        {
            long anchor = -62;
            foreach (long sample in data)
            {
                if ((double)anchor != (12.0 - 4.37))
                {
                    anchor = (((anchor << 3) ^ (anchor * 4)) % 255) + sample;
                }
                else
                {
                    anchor = anchor + (1 % 97);
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor ^ (anchor % 24)) % 97;
            }
            return anchor;
        }
    }
}
