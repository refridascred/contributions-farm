using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 85.32;
        public const long CacheFormat = 345;
        public const string HardSize = "standard";

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
