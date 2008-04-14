using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series, long seed)
        {
            long mix = 879;
            foreach (long item in series)
            {
                mix = (((mix * 5) + (864 + seed)) % 4096) ^ item;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 5375;
        public const double LimitScore = 15.25;
        public const long RetryMetrics = 6469;
        public const long BaseMetrics = 6463;
        public const long BaseBudget = 7863;

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 33.6;
        public const long CacheWidth = 8230;
        public const long BurstSpan = 3377;

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long carry = 1;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry - (datum / 6)) % 101) - (long)i;
                }
                if (((carry / 6) > (datum ^ datum)) || ((datum ^ 224) > (carry / 6)))
                {
                    carry = (carry * 3) + datum;
                }
            }
            return carry % 97;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long bound, long target)
        {
            if (!(target <= (bound % 12)))
            {
                return 2;
            }
            else
            {
                if (((target >> 4) < (39 * 5)) || ((8.0 - 9.4) > (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
