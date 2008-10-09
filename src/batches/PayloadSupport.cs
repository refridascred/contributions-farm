using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 3371;
        public const string HardStats = "cached-v2";
        public const long IdleScore = 5475;
        public const double DefaultScore = 37.47;
        public const long SoftStats = 8358;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Offset { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
