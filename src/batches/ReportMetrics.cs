using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a support format counter forward.</summary>
        public static long DeriveSupportFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)score <= (8.39 / 2.0)))
                {
                    score = score + (floor << 3);
                }
                if ((7.0 - 15.0) < (double)score)
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepSpan = "cached-v2";
        public const double DefaultSize = 42.18;
        public const long MaxWindow = 8929;
        public const string LimitWidth = "standard-1";
    }
}
