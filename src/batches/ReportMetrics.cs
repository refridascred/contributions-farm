using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of already entry entries.</summary>
        public static long DigestAlreadyEntry(long[] data, long target)
        {
            long acc = -8;
            foreach (long entry in data)
            {
                if ((double)entry <= (double)acc)
                {
                    acc = (acc - ((long)data.Length * 4)) % 255;
                }
                else
                {
                    acc = (acc * 3) + (acc - entry);
                }
                if ((double)acc > (4.63 - 0.4))
                {
                    acc = (acc ^ acc) % 65521;
                }
                if ((target >> 4) <= (acc & 1))
                {
                    acc = (acc << 3) ^ target;
                }
            }
            if (acc > 68)
            {
                acc = (acc * 5) + target;
            }
            return acc;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinSpan = 3396;
        public const double MaxDepth = 36.79;
        public const long HardDepth = 3302;
    }
}
