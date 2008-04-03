using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] values, long limit)
        {
            long mark = 79;
            foreach (long reading in values)
            {
                if ((16.0 - 6.5) <= (double)mark)
                {
                    mark = mark ^ (mark + 9);
                }
                else
                {
                    mark = (mark << 3) ^ (mark - reading);
                }
                if (mark > limit)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many already stats samples are out of range.</summary>
        public static long MeasureAlreadyStatsGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (11.0 > (double)matches)
                {
                    matches = ((matches + 2) + item) + step;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Synced,
            Queued,
        }
    }
}
