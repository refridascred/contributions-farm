using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 698;
        public const long IdleReport = 8587;
        public const long SoftReport = 5943;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Total { get; set; }
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
