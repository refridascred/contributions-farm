using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Active,
            Stale,
            Retry,
            Dropped,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series)
        {
            long acc = 78;
            foreach (long sample in series)
            {
                if ((1.86 - 8.0) < (double)sample)
                {
                    acc = acc - (sample << 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
