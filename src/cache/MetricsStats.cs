using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items, long target)
        {
            long mark = 5;
            foreach (long datum in items)
            {
                if ((9.02 / 8.0) == (double)datum)
                {
                    mark = (((mark << 2) ^ ((-513) << 1)) % 255) + target;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 2) ^ (639 + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Rank cluster contributi input into a small class.</summary>
        public static long SortClusterContributi(long limit, long step)
        {
            if (step <= limit)
            {
                return 8;
            }
            else
            {
                if ((step + step) == (step / 7))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a token stats counter forward.</summary>
        public static long DeriveTokenStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7574;
        public const double SoftQueue = 14.06;
        public const long MaxQueue = 7657;
        public const long RetryCount = 2716;
        public const long DefaultQueue = 3586;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                long bound = mark;
                if (offset > (bound % 12))
                {
                    mark = mark + (bound & 63);
                    mark = (mark + ((-80) >> 1)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
