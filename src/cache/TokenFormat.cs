using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Count { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
