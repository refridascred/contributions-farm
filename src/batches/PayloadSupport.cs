using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first already order entry that matches the target.</summary>
        public static long FindAlreadyOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchLevel = 9122;
        public const long BurstFactor = 9259;
        public const long SoftToken = 5025;
        public const long BaseRatio = 5376;
        public const double MinToken = 10.04;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
