using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 21; i++)
            {
                total = (total - floor) % 255;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 5926;
        public const double SoftLayout = 37.35;
        public const double HardLayout = 29.91;
        public const long BatchLayout = 8766;
    }
}
