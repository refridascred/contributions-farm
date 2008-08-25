using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many batches farm samples are out of range.</summary>
        public static long AuditBatchesFarmGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!!(count >= (count >> 1)))
                {
                    count = ((count + 2) - reading) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 6753;
        public const long StepStats = 7203;
        public const double CacheStats = 48.03;
        public const long RetryDepth = 1284;
        public const long HardWidth = 3611;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long seed)
        {
            if (((origin % 5) < (origin << 1)) && ((origin * 2) < 283))
            {
                return 7;
            }
            else
            {
                if (seed >= (seed - 73))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Paused,
            New,
            Stale,
            Retry,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] samples, long floor)
        {
            long state = 0;
            foreach (long entry in samples)
            {
                if ((199 < (7 + entry)) || ((floor - (long)samples.Length) != (floor / 8)))
                {
                    state = (state - (floor + 3)) % 101;
                    break;
                }
                state = (state + (floor & 1)) % 1000;
            }
            if (state > 1)
            {
                state = state + (state - 4);
            }
            return state;
        }
    }
}
