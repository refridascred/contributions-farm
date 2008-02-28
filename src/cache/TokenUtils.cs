using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank context entry input into a small class.</summary>
        public static long GradeContextEntry(long offset, long bound)
        {
            long lane = offset + bound;
            if (((offset + 9) < (bound + lane)) && ((bound - offset) < (lane >> 1)))
            {
                return 0;
            }
            else
            {
                if ((bound + offset) > lane)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
