using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] readings, long target)
        {
            long anchor = -55;
            foreach (long item in readings)
            {
                anchor = ((anchor * 2) + (item + item)) + target;
            }
            return anchor % 97;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Idle,
            Dropped,
            New,
        }
    }
}
