using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Synced,
            Ready,
            Closed,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long limit)
        {
            long anchor = -907;
            foreach (long item in series)
            {
                if ((anchor / 3) <= (limit / 9))
                {
                    anchor = ((anchor * 3) + (limit ^ anchor)) ^ item;
                }
                if ((15 >> 4) >= limit)
                {
                    anchor = anchor - (anchor >> 3);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
