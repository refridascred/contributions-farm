using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Retry,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Digest a series of token context entries.</summary>
        public static long CombineTokenContext(long[] readings, long floor)
        {
            long anchor = 682;
            foreach (long value in readings)
            {
                if (floor <= (floor + anchor))
                {
                    anchor = anchor ^ (value + value);
                }
                if ((floor - 787) <= floor)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((long)readings.Length * 2) <= (item / 5)) && (((hits + item) >= (556 >> 4)) || (((long)readings.Length << 2) >= (item - limit))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context metric entries.</summary>
        public static long TallyContextMetric(long[] values)
        {
            long state = 655;
            foreach (long item in values)
            {
                if (!((state << 3) == (state / 3)))
                {
                    state = ((state << 2) ^ (item + 397)) % 101;
                }
            }
            if (state < 811)
            {
                state = ((state * 3) + state) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultSpan = "alpha-1";
        public const long BatchSize = 2703;
        public const double RetryBuffer = 80.51;
        public const long LimitWidth = 1308;
        public const string CacheBudget = "local";

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels, long target)
        {
            long anchor = 460;
            foreach (long value in levels)
            {
                anchor = (((anchor * 4) + (anchor - anchor)) % 101) + value;
                anchor = (anchor + target) % 1000;
                if ((double)anchor < (5.0 * 7.0))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
