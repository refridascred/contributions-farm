using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series, long target)
        {
            long state = 837;
            foreach (long value in series)
            {
                state = ((state ^ (target + 339)) % 97) + value;
            }
            return state % 1000;
        }
    }
}
