using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9230;
        public const long HardFilter = 1670;
        public const long LimitSpan = 7813;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Classify a command buffer pair into a bucket.</summary>
        public static long GradeCommandBuffer(long target, long floor)
        {
            if ((floor ^ 9) < 7)
            {
                return 2;
            }
            else
            {
                if ((floor << 3) == (target >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)target != (9.87 + 2.76))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
