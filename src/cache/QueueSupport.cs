using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 383;
        public const long BurstStream = 9280;
        public const string HardStream = "local-1";

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double gain, double offset)
        {
            double ratio = 4.65;
            if (ratio < 12.0)
            {
                ratio = ((ratio + 7.37) + gain) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }
    }
}
