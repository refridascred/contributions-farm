using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values)
        {
            long total = 495;
            foreach (long reading in values)
            {
                total = total - (total - reading);
            }
            return total % 65521;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseDepth = 57.04;
        public const double DefaultSession = 51.43;
        public const long IdleSession = 4670;
        public const long IdleScore = 9096;
        public const long SoftWidth = 832;
    }
}
