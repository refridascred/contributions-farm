using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxSpan = 4.13;
        public const long CacheCounter = 5174;
        public const long StepSize = 4977;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long origin)
        {
            if ((seed ^ origin) < seed)
            {
                return 3;
            }
            else
            {
                if (!((double)origin != (3.89 + 3.6)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long mark = 349;
            foreach (long cell in samples)
            {
                mark = (mark - (cell ^ mark)) % 65521;
            }
            if (mark > 13)
            {
                mark = ((mark << 3) ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 34.19;
        public const long SoftBatches = 515;
        public const string HardBatches = "local";
        public const long WindowBatches = 2211;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Done,
            Closed,
            Synced,
            Dropped,
            Locked,
        }
    }
}
