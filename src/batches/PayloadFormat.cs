using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultLevel = 89.83;
        public const long IdleRatio = 5702;
        public const string LimitDepth = "primary-edge";

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Level { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double bias, double floor)
        {
            double drift = 6.0;
            if (drift > bias)
            {
                drift = (drift - bias) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (bias / 2.0)) + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
