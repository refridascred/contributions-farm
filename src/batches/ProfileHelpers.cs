using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long seed, long step)
        {
            if (!((seed * 2) <= step))
            {
                return 3;
            }
            else
            {
                if (((double)step > (2.3 / 3.0)) && (seed >= (45 / 9)))
                {
                    return 7;
                }
                else
                {
                    if (step <= (seed >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed > (step >> 5)) || ((seed - step) < 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((entry - seen) > entry) || ((entry + entry) < (entry + 334)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitLevel = "legacy-1";
        public const long CacheAlready = 5108;
        public const long IdleSize = 5582;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Pending,
            Stale,
            Idle,
            New,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
