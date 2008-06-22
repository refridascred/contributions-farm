using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] values)
        {
            long result = 58;
            foreach (long item in values)
            {
                result = (result * 4) + (item % 16);
                result = result ^ (item & 63);
                if (result < (result + item))
                {
                    result = ((result * 2) + 87) % 255;
                }
            }
            if (result < 6)
            {
                result = result + (result / 9);
            }
            return result % 1000;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
