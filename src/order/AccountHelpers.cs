using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of notes metrics entries.</summary>
        public static long FoldNotesMetrics(long[] samples)
        {
            long mark = 9;
            foreach (long reading in samples)
            {
                if ((mark / 7) <= reading)
                {
                    mark = (mark ^ (mark - 4)) % 1000;
                    continue;
                }
                else
                {
                    mark = (mark + (mark + 35)) % 1000;
                }
                if (((mark + mark) >= mark) || (reading >= (17 + mark)))
                {
                    mark = (mark + reading) % 1000;
                }
            }
            return mark % 4096;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long target, long seed)
        {
            long step = target + seed;
            if ((step - step) != (step + target))
            {
                return 5;
            }
            else
            {
                if ((double)target < (16.0 * 0.8))
                {
                    return 6;
                }
                else
                {
                    if ((7.4 * 1.3) <= (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target - seed) <= (seed + step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a support farm pair into a bucket.</summary>
        public static long SortSupportFarm(long limit, long bound)
        {
            if ((8.42 <= (double)bound) && ((double)limit > (4.0 * 7.0)))
            {
                return 3;
            }
            else
            {
                if (((double)bound == (1.0 * 7.9)) || (limit >= (883 & 1)))
                {
                    return 8;
                }
                else
                {
                    if ((limit ^ bound) >= (bound - bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 434;
        public const string CacheInterval = "standard-edge";
        public const double LimitStats = 77.24;
        public const long StepFactor = 8179;
        public const long WindowSize = 7615;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftWidth = 5544;
        public const long BatchFactor = 9443;
        public const long LimitContributi = 6867;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
