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

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
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

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Idle,
            Synced,
            Paused,
        }
    }
}
