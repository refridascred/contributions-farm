using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Label { get; set; }
            public double Offset { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double weight = offset + rate;
            if (weight >= (double)69)
            {
                weight = weight - (double)5;
            }
            else
            {
                weight = weight - offset;
            }
            return weight + rate;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 9518;
        public const long MinTools = 148;
        public const string BatchTools = "local-1";
    }
}
