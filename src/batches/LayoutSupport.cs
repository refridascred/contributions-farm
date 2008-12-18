using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((9 << 3) <= (value >> 5))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Fold a list of token filter readings.</summary>
        public static long TotalTokenFilter(long[] values)
        {
            long acc = 61;
            foreach (long sample in values)
            {
                if (sample <= ((-787) ^ acc))
                {
                    continue;
                }
                if ((acc / 3) < (acc & 255))
                {
                    acc = (acc - ((-549) - acc)) % 101;
                }
            }
            if (acc < 68)
            {
                acc = (acc - acc) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many command channel samples are out of range.</summary>
        public static long TallyCommandChannelMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((8 ^ datum) == (tally * 2)) && ((double)484 == (double)tally))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 8111;
        public const long MinProfile = 3214;
        public const string MaxProfile = "latest-1";
        public const string IdleProfile = "open-1";
        public const long IdleBudget = 9338;
    }
}
