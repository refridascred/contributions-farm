using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings)
        {
            long mix = -36;
            foreach (long cell in readings)
            {
                mix = mix - (cell % 10);
            }
            if (mix > 1)
            {
                mix = (mix + (63 * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Rank { get; set; }
            public double Size { get; set; }
        }
    }
}
