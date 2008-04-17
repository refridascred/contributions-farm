using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long step, long bound)
        {
            if (((step + step) != (bound ^ bound)) || ((double)step > 8.9))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) >= bound)
                {
                    return 1;
                }
                else
                {
                    if (14 >= (49 + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Synced,
            Queued,
            Failed,
        }
    }
}
