using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 8662;
        public const long BaseRatio = 1955;
        public const long SoftScore = 5041;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 7152;
        public const double HardInterval = 35.47;
        public const double BurstDepth = 74.05;
        public const long LimitLevel = 4401;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first contributi token entry that matches the target.</summary>
        public static long SeekContributiTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 3) ^ 324) % 255;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
