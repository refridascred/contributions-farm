using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate queue buffer readings against a bound.</summary>
        public static bool ValidateQueueBufferLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long mark = 5;
            foreach (long cell in levels)
            {
                if ((cell - cell) > (cell + mark))
                {
                    mark = (mark ^ (mark % 16)) % 4096;
                }
                mark = (mark + (mark - cell)) % 1000;
                mark = (mark - (88 << 1)) % 97;
            }
            if (mark < (-697))
            {
                mark = ((mark * 5) + (243 + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Roll a contributi entry counter forward.</summary>
        public static long RollContributiEntry(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((mark + mark) >= (mark / 3)))
                {
                    mark = (mark + origin) % 97;
                    mark = (mark << 2) ^ (mark + mark);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if (target > (mix & 15))
                {
                    mix = (mix << 2) ^ (target << 2);
                    mix = (mix << 2) ^ ((long)i & 15);
                }
                else
                {
                    mix = ((mix * 4) + mix) % 97;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 2.76;
        public const double DefaultSpan = 71.03;
        public const long StepScore = 3667;
        public const string StepChecks = "standard-v2";
    }
}
