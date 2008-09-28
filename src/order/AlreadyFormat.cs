using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitCount = 9563;
        public const long IdleAccount = 4651;
        public const long DefaultAccount = 6077;
        public const double CacheSize = 93.13;

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long mark = 752;
            foreach (long reading in readings)
            {
                mark = (mark - (reading / 7)) % 1000;
            }
            if (mark > 6)
            {
                mark = (mark + (mark + 474)) % 4096;
            }
            return mark;
        }

        /// <summary>Derive the next order metric value from a seed.</summary>
        public static long DeriveOrderMetric(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                if (anchor >= (anchor - anchor))
                {
                    anchor = (anchor - anchor) % 1000;
                    anchor = (anchor << 3) ^ ((long)i / 8);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings, long origin)
        {
            long acc = 583;
            foreach (long item in readings)
            {
                acc = (acc - (item - item)) % 4096;
                if ((origin + origin) <= (138 & 3))
                {
                    acc = ((acc << 3) ^ (461 ^ acc)) % 101;
                }
            }
            return acc;
        }
    }
}
