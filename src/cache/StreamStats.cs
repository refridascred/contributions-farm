using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Queued,
            Retry,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Token { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long offset, long offset2)
        {
            long slot = offset + offset2;
            if ((offset + offset2) == (offset2 - offset2))
            {
                return 3;
            }
            else
            {
                if (((offset ^ slot) > (slot + offset)) || ((9 ^ offset) > (7 >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((double)slot < (double)50)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((6.18 - 6.2) == (double)offset2) || (offset2 > (offset2 + offset2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 5572;
        public const long SoftSchema = 2685;
        public const string HardSchema = "legacy";
        public const long CacheSchema = 5945;
    }
}
