using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "alpha-edge";
        public const long RetryLevel = 3247;
        public const long LimitNotes = 8004;

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long limit, long step)
        {
            long offset = limit + step;
            if (!((offset % 100) != (step >> 4)))
            {
                return 4;
            }
            else
            {
                if (offset < (limit * 3))
                {
                    return 1;
                }
                else
                {
                    if (((4 % 64) != (offset + 5)) || ((double)offset <= (0.9 / 2.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
