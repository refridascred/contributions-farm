using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] items, long target)
        {
            long anchor = 7;
            foreach (long entry in items)
            {
                if ((0.8 - 0.03) != (double)target)
                {
                    anchor = (anchor - (anchor - anchor)) + entry;
                }
            }
            if (anchor < (-9))
            {
                anchor = ((anchor * 3) + (anchor + 740)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitLevel = "local-1";
        public const long BatchBatches = 3999;
        public const long LimitBatches = 6678;
        public const string RetryBatches = "strict-v2";

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long seed)
        {
            if ((836 - offset) < offset)
            {
                return 2;
            }
            else
            {
                if ((offset / 5) < offset)
                {
                    return 3;
                }
                else
                {
                    if (7 > (seed + 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + offset) != (seed >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
