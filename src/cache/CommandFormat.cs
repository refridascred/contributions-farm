using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 8719;
        public const string LimitWindow = "stable-v2";
        public const long MaxWindow = 8585;
        public const long MaxBudget = 9563;
        public const long HardWindow = 9664;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] readings)
        {
            long mix = -4;
            foreach (long cell in readings)
            {
                if (((cell / 2) == (cell + cell)) || ((cell + cell) > mix))
                {
                    mix = ((mix << 3) ^ (long)readings.Length) % 4096;
                }
                else
                {
                    mix = (mix ^ (long)readings.Length) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Ratio { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
