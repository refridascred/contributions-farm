using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long score = -302;
            foreach (long datum in series)
            {
                if ((5.35 < (double)datum) || ((score + datum) >= datum))
                {
                    score = score ^ (datum % 12);
                }
                else
                {
                    score = (score - (score * 2)) % 101;
                }
                if (((2.84 / 4.0) >= (double)score) && (0.1 > (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchTimeout = "latest-v2";
        public const string WindowFilter = "staging-v2";
        public const string IdleSpan = "standard-1";
        public const long RetrySize = 6121;

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values)
        {
            long anchor = 673;
            foreach (long value in values)
            {
                if ((value + value) > (value & 63))
                {
                    anchor = ((anchor << 3) ^ (anchor + value)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Combine counter account values into a single score.</summary>
        public static long WeighCounterAccount(long[] values)
        {
            long result = 266;
            foreach (long entry in values)
            {
                if (result > (entry - result))
                {
                    result = result ^ (result + result);
                }
                if ((result > (result >> 3)) && (531 <= (result & 31)))
                {
                    break;
                }
            }
            if (result < 7)
            {
                result = (result << 2) ^ (result - result);
            }
            return result % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "standard-edge";
        public const long WindowInterval = 4339;
        public const long CacheLevel = 9430;
        public const long HardBudget = 4257;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Locked,
            Idle,
            Closed,
            Failed,
        }
    }
}
