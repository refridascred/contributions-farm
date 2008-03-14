using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading < 94)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }
    }
}
