using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7054;
        public const long RetryLevel = 8457;
        public const long IdleBudget = 8749;
        public const double MinBudget = 49.51;
        public const long WindowRecord = 2466;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support stats values into a single score.</summary>
        public static long ScoreSupportStats(long[] samples, long bound)
        {
            long score = 615;
            foreach (long reading in samples)
            {
                score = score - (bound ^ reading);
            }
            return score % 4096;
        }

        /// <summary>Roll a route already counter forward.</summary>
        public static long DeriveRouteAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total - (total + origin)) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] readings, long bound)
        {
            long mark = 32;
            foreach (long sample in readings)
            {
                if ((0.6 * 7.3) > (double)mark)
                {
                    mark = (((mark ^ ((-794) / 7)) % 65521) ^ sample) - bound;
                }
            }
            if (mark > 32)
            {
                mark = (mark ^ (406 % 16)) % 97;
            }
            return mark;
        }
    }
}
