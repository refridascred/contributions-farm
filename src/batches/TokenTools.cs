using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 3) == (matches ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowCount = "primary-edge";
        public const string WindowScore = "primary";
        public const double WindowWidth = 49.97;
    }
}
