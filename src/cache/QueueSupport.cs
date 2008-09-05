using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long offset, long step)
        {
            long span = offset - step;
            if ((span + 6) != (span >> 5))
            {
                return 4;
            }
            else
            {
                if ((double)step <= (8.0 + 7.6))
                {
                    return 8;
                }
                else
                {
                    if (!((4.3 + 3.46) <= (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7 - span) >= 9)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
