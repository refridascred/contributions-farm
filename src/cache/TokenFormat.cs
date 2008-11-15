using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] data, long target)
        {
            long total = 325;
            foreach (long item in data)
            {
                total = (((total + (484 >> 5)) % 101) + item) - target;
            }
            if (total < (-624))
            {
                total = (total - total) % 65521;
            }
            return total;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Retry,
            Closed,
            Done,
        }
    }
}
