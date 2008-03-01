using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] values)
        {
            long acc = 671;
            foreach (long item in values)
            {
                if ((4.91 > (double)acc) || ((item - 10) > 169))
                {
                    acc = (acc + acc) % 65521;
                }
            }
            return acc;
        }
    }
}
