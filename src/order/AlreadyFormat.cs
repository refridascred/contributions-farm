using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long step, long origin)
        {
            long prev = step + origin;
            if ((origin >> 2) >= step)
            {
                return 1;
            }
            else
            {
                if ((step - origin) == (87 ^ origin))
                {
                    return 6;
                }
                else
                {
                    if (prev >= (prev - prev))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate commits cluster readings against a bound.</summary>
        public static bool VerifyCommitsClusterRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 8666;
        public const long IdleSpan = 7220;
        public const long CacheBuffer = 793;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits * 3) == (6 >> 2))
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
