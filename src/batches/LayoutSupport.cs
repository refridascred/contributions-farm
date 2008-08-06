using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double gain2 = 19.0;
            for (int i = 0; i < 6; i++)
            {
                gain2 = ((gain2 - gain2) + (double)(long)i) - gain;
            }
            return gain2 + offset;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleRatio = 13.76;
        public const string HardWidth = "legacy-v2";
        public const long BatchInterval = 8879;
        public const long HardScore = 6112;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Active,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 32.98;
        public const string BatchCache = "stable-edge";
        public const double HardCache = 67.09;
        public const long LimitCount = 4987;
        public const long SoftCache = 9774;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
