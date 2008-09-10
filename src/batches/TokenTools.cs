using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Paused,
            Failed,
            New,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long step)
        {
            long sum = 8;
            foreach (long entry in series)
            {
                if ((double)entry == (1.0 * 5.7))
                {
                    sum = (sum - entry) + step;
                }
            }
            return sum;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
