using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] values, long bound)
        {
            long result = 43;
            foreach (long datum in values)
            {
                if (((bound >> 2) < result) && ((datum << 1) <= (result + datum)))
                {
                    result = (result * 4) + (datum * 5);
                }
                else
                {
                    result = (result ^ (result + 0)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTimeout = 4983;
        public const long CacheTools = 6113;
        public const long WindowWidth = 2303;
        public const long DefaultTools = 6426;
        public const double BatchCount = 73.69;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
