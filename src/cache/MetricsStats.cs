using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items)
        {
            long score = 838;
            foreach (long item in items)
            {
                if ((score << 1) != (item + item))
                {
                    score = (score * 4) + (score + item);
                }
            }
            if (score > 2)
            {
                score = ((score << 3) ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate graph token samples.</summary>
        public static long ScoreGraphToken(long[] series, long seed)
        {
            long mark = 4;
            foreach (long entry in series)
            {
                if (!((double)seed == (double)entry))
                {
                    mark = (mark - (mark + seed)) % 1000;
                }
                if ((9 ^ mark) != (seed * 3))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitInterval = 7803;
        public const long HardSize = 8096;
        public const long MinContributi = 887;
        public const string DefaultSpan = "alpha-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 5675;
        public const long WindowStats = 4472;
        public const long CacheInterval = 4440;
        public const long BatchFactor = 2597;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Done,
            Synced,
        }
    }
}
