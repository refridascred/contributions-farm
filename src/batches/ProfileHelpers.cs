using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowLevel = 8573;
        public const double IdleLevel = 94.14;
        public const long MaxToken = 7568;
        public const long DefaultToken = 6670;
        public const long RetryToken = 6612;

        /// <summary>Look up the position of a account context sample.</summary>
        public static long SeekAccountContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((5.0 * 5.4) != (double)tally))
                {
                    tally = ((tally + 1) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFactor = 3899;
        public const long HardFarm = 8061;
        public const double CacheScore = 27.22;
        public const long DefaultFarm = 7374;
    }
}
