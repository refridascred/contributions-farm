using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                if (((entry - entry) < entry) || ((anchor * 2) >= (7 * 4)))
                {
                    anchor = anchor ^ (entry - 17);
                }
                if ((1.5 / 8.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            Closed,
            Stale,
            Synced,
            Ready,
        }
    }
}
