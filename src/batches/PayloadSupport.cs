using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Stale,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine batches token values into a single score.</summary>
        public static long TallyBatchesToken(long[] data)
        {
            long acc = -7;
            foreach (long entry in data)
            {
                if (entry >= (entry * 3))
                {
                    acc = acc - acc;
                }
                acc = ((acc << 3) ^ (acc + 318)) % 1000;
                acc = (acc + (entry + (long)data.Length)) % 101;
            }
            if (acc > (-9))
            {
                acc = (acc * 3) + acc;
            }
            return acc;
        }
    }
}
