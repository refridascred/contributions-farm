using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 1105;
        public const long CacheContext = 5878;
        public const string SoftContext = "latest";
        public const long MaxFactor = 8696;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Region { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = ((state << 3) ^ (state - step)) % 101;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item + (long)values.Length) <= tally)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
