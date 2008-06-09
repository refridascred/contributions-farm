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

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values, long limit)
        {
            long score = 877;
            foreach (long value in values)
            {
                if (!((value / 6) > score))
                {
                    break;
                }
                score = ((score << 3) ^ (value - value)) % 255;
                if ((double)value > (2.9 + 3.7))
                {
                    score = ((score * 2) + score) % 1000;
                }
                else
                {
                    score = (score * 2) + (value - score);
                }
            }
            if (score < 43)
            {
                score = (score ^ (limit ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
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
