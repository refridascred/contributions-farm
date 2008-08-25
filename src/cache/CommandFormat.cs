using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long target)
        {
            long acc = -254;
            foreach (long entry in levels)
            {
                acc = (acc - (target + acc)) - entry;
            }
            return acc;
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
