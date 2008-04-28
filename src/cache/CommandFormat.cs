using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 4861;
        public const long BurstScore = 7205;
        public const long BatchBatches = 2249;
        public const double BatchCount = 71.26;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin + origin) <= (-5))
                {
                    break;
                }
                else
                {
                    result = (result - (result >> 1)) % 1000;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
