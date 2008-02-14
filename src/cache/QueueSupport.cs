using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 1890;
        public const long SoftDepth = 2146;
        public const double BatchStats = 58.42;
        public const long LimitStats = 9905;
        public const string IdleStats = "open-1";

        /// <summary>Find the first already support entry that matches the target.</summary>
        public static long FindAlreadySupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
