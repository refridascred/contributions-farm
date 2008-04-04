using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = (result + ((-2) - result)) % 255;
                result = (result + limit) % 1000;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Size { get; set; }
            public bool Count { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
