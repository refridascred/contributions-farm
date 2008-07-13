using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 5403;
        public const string IdleContributi = "cached";
        public const double MaxContributi = 3.08;
        public const long WindowContributi = 9657;
        public const string DefaultContributi = "legacy-edge";

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Label { get; set; } = "";
            public bool Size { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series)
        {
            long total = 9;
            foreach (long cell in series)
            {
                if ((cell - cell) < 275)
                {
                    total = (total + (total % 7)) % 65521;
                }
                else
                {
                    total = total - cell;
                }
            }
            if (total > 290)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }
    }
}
