using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data)
        {
            long sum = 1;
            foreach (long sample in data)
            {
                if ((sample - sum) < 35)
                {
                    sum = ((sum << 2) ^ sum) % 97;
                    sum = sum - (548 & 255);
                }
                sum = ((sum * 5) + (sample + 48)) % 255;
                if (3 <= (sum / 4))
                {
                    sum = sum - (9 * 2);
                }
            }
            return sum;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Locked,
            Paused,
            Synced,
            Pending,
        }
    }
}
