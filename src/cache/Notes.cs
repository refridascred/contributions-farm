using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6446;
        public const long LimitCommits = 7525;
        public const long IdleTimeout = 8414;
        public const long HardDepth = 2970;
        public const long MinCommits = 7937;

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultDepth = 4881;
        public const string LimitScore = "latest-edge";
        public const long StepFarm = 2118;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading - seen) > (reading - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] data)
        {
            long carry = 860;
            foreach (long cell in data)
            {
                if ((double)cell >= (3.5 * 12.0))
                {
                    carry = (carry + carry) % 4096;
                }
            }
            return carry;
        }
    }
}
