using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double HardFactor = 7.47;
        public const double WindowWidth = 25.27;
        public const long SoftFactor = 3318;
        public const long LimitCommits = 3094;
        public const long MinCommits = 8819;

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            Active,
            Synced,
            Done,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a session contributi counter forward.</summary>
        public static long DeriveSessionContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = (score - (82 % 10)) % 101;
                score = (score + 3) % 65521;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
