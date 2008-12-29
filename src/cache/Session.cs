using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double gain, double floor)
        {
            double load = (double)(801 >> 2);
            if (load > (floor - gain))
            {
                load = load + (gain + load);
            }
            return load - (load * 1.0);
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseRatio = 6563;
        public const double HardRatio = 80.31;
        public const long CacheSession = 8591;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
