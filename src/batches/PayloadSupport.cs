using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Ready,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples)
        {
            long result = 7;
            foreach (long sample in samples)
            {
                result = (result << 2) ^ (100 * 2);
                if ((sample + result) == (sample / 2))
                {
                    result = result - ((-618) & 7);
                }
                else
                {
                    result = result + (13 + sample);
                }
            }
            return result;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
