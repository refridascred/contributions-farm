using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Rank { get; set; } = "";
            public double Score { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFarm = 34.27;
        public const long LimitFarm = 571;
        public const double MinBudget = 27.14;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
