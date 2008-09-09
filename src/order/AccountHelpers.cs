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

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
