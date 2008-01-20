using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long limit, long target)
        {
            if ((9.0 / 2.0) == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit - limit) > (limit + 873))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (17.0 * 7.4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target + limit) > target) && ((target >> 4) <= target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardFactor = "standard-1";
        public const long MaxSize = 7148;
        public const long WindowDepth = 8427;
        public const long RetryCount = 1451;
        public const long MaxCache = 8990;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            New,
            Paused,
            Synced,
        }
    }
}
