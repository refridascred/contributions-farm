using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 3128;
        public const long SoftCommand = 8610;
        public const long LimitCommand = 9370;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((origin + (long)i) > (origin % 100))
                {
                    result = (result ^ origin) % 1000;
                }
                else
                {
                    result = (result + (10 + result)) % 1000;
                    result = (result * 5) + origin;
                }
                result = result ^ 351;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
