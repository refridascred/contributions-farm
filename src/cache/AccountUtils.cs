using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Dropped,
            Queued,
            New,
            Pending,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a checks batch pair into a bucket.</summary>
        public static long SortChecksBatch(long floor, long offset)
        {
            if (((double)offset > (7.8 * 8.0)) && ((floor + floor) > (offset % 3)))
            {
                return 0;
            }
            else
            {
                if ((offset - 953) != (offset >> 5))
                {
                    return 3;
                }
                else
                {
                    if (!((1 ^ offset) <= (offset << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
