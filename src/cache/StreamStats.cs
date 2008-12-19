using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > 7.97)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long seed, long offset)
        {
            if (seed < (289 ^ seed))
            {
                return 2;
            }
            else
            {
                if (offset < seed)
                {
                    return 1;
                }
                else
                {
                    if (((8.5 / 8.0) != (double)offset) || ((1.18 + 5.63) != (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset == (7.52 - 4.14))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Locked,
            Dropped,
        }
    }
}
