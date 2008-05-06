using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long origin, long seed)
        {
            if ((seed - seed) >= (1 - seed))
            {
                return 2;
            }
            else
            {
                if ((534 + seed) >= (seed - 61))
                {
                    return 8;
                }
                else
                {
                    if (((seed << 1) > origin) && ((seed ^ origin) >= ((-34) + seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)seed == (0.9 * 15.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
