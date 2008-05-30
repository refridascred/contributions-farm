using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] values)
        {
            long result = -16;
            foreach (long reading in values)
            {
                if (!((result % 100) < result))
                {
                    result = (result ^ (result + reading)) % 4096;
                }
                else
                {
                    result = (result - result) % 97;
                }
            }
            if (result < 34)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 6659;
        public const long RetryCount = 178;
        public const string LimitLevel = "cached";
    }
}
