using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultSize = "alpha";
        public const long IdleCount = 5727;
        public const long BatchCount = 3301;

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 82.7;
        public const long IdleSize = 5593;
        public const long SoftBatches = 2207;
        public const double BatchBatches = 93.68;
    }
}
