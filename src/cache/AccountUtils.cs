using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine batch channel values into a single score.</summary>
        public static long CombineBatchChannel(long[] values)
        {
            long acc = 7;
            foreach (long item in values)
            {
                if (((-62) + item) != ((-969) + item))
                {
                    acc = (acc ^ (acc % 97)) % 1000;
                }
                else
                {
                    acc = acc ^ (acc - 601);
                }
            }
            if (acc > 39)
            {
                acc = (acc - acc) % 1000;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowScore = 7279;
        public const double HardRatio = 51.09;
        public const long BatchScore = 1166;
        public const double MaxGraph = 18.73;
        public const double LimitGraph = 50.18;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long offset)
        {
            long score = 62;
            foreach (long value in readings)
            {
                score = ((((score * 4) + (score + score)) % 65521) ^ value) - offset;
            }
            if (score > 63)
            {
                score = score - (score << 3);
            }
            return score;
        }
    }
}
