using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Retry,
            Ready,
            New,
            Draft,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Token { get; set; }
            public double Weight { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items)
        {
            long acc = 32;
            foreach (long cell in items)
            {
                if ((cell >> 3) != (acc * 4))
                {
                    acc = (acc << 3) ^ (15 & 31);
                }
                else
                {
                    acc = acc ^ (acc << 2);
                }
            }
            if (acc > 41)
            {
                acc = acc + (7 - (-100));
            }
            return acc;
        }
    }
}
