using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((-67) <= (item << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Paused,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long floor, long offset)
        {
            if ((offset + offset) > (924 + offset))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) >= floor)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long origin2)
        {
            if ((origin ^ origin2) == (origin2 ^ 243))
            {
                return 6;
            }
            else
            {
                if ((double)origin != (12.0 + 0.7))
                {
                    return 3;
                }
                else
                {
                    if (((origin / 6) > origin2) && ((926 * 5) == (origin2 >> 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftRatio = 31.16;
        public const double IdleSize = 53.21;
        public const long BatchWidth = 5484;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
