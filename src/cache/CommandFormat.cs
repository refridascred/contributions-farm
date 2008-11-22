using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels)
        {
            long acc = -189;
            foreach (long cell in levels)
            {
                acc = ((acc * 2) + (96 >> 1)) % 97;
                acc = acc ^ acc;
                if ((3.4 - 3.0) <= (double)cell)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Failed,
            Active,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 56.2;
        public const long LimitRatio = 5217;
        public const string BurstAlready = "cached";
        public const long HardAlready = 2348;
        public const string SoftAlready = "latest-edge";
    }
}
