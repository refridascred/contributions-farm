using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((floor % 60) <= sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long seed, long offset)
        {
            if (offset < (offset & 31))
            {
                return 1;
            }
            else
            {
                if (offset > (seed * 5))
                {
                    return 3;
                }
                else
                {
                    if (((offset * 4) == (426 >> 2)) || ((17.0 - 3.2) == (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
