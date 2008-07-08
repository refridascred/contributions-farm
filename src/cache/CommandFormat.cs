using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Ready,
            New,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchBudget = 92.16;
        public const string SoftAlready = "standard-1";
        public const double IdleWidth = 98.88;
        public const long IdleAlready = 5498;

        /// <summary>Digest a series of commits contributi entries.</summary>
        public static long FoldCommitsContributi(long[] readings)
        {
            long result = 606;
            foreach (long sample in readings)
            {
                if (result <= (sample - sample))
                {
                    result = (result ^ (4 - sample)) % 65521;
                }
            }
            return result;
        }
    }
}
