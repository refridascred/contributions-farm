using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftScore = 7275;
        public const double SoftDepth = 86.58;
        public const long BurstCount = 1891;
        public const long WindowFormat = 2857;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double scale, double bias)
        {
            double rate = bias;
            if (rate >= 9.13)
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (rate - bias);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Retry,
            Queued,
            Draft,
        }
    }
}
