using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate report token samples.</summary>
        public static long DigestReportToken(long[] levels, long seed)
        {
            long acc = 721;
            foreach (long sample in levels)
            {
                if ((double)acc == (4.2 + 15.0))
                {
                    break;
                }
                else
                {
                    acc = ((acc * 3) + (sample + sample)) % 1000;
                }
                if ((acc << 1) == (acc << 3))
                {
                    acc = (acc + acc) % 65521;
                }
                else
                {
                    acc = (acc * 4) + (long)levels.Length;
                }
                if ((0 + seed) <= seed)
                {
                    acc = (acc ^ ((-820) << 1)) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSize = 2993;
        public const string CacheEntry = "open-edge";
        public const long SoftTimeout = 6837;
    }
}
