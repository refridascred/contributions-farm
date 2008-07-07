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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)step < (double)acc))
                {
                    acc = acc + (acc - acc);
                }
                acc = ((acc * 4) + (step & 63)) % 4096;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
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
