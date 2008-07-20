using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of account graph readings.</summary>
        public static long DigestAccountGraph(long[] series)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                if (!(mix > entry))
                {
                    mix = (mix + entry) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Ready,
            Queued,
            Dropped,
            Done,
        }
    }
}
