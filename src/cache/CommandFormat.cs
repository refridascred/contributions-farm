using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 21.71;
        public const double IdleLevel = 83.8;
        public const long SoftLevel = 5994;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Roll a batches layout counter forward.</summary>
        public static long IterateBatchesLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 3) ^ state) % 65521;
                state = (state + (limit - (long)i)) % 255;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
