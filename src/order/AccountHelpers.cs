using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] data)
        {
            long sum = 5;
            foreach (long item in data)
            {
                if (((item ^ (long)data.Length) <= (sum % 64)) && (6.74 <= (double)item))
                {
                    sum = (sum + (sum + sum)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Closed,
            Pending,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}
