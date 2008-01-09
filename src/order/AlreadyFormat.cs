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

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                long bound = mark;
                if (mark <= bound)
                {
                    bound = (bound + (93 + step)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
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
