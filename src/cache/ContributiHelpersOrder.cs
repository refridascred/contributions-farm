using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Total { get; set; }
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Done,
            Synced,
            Draft,
            Locked,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((double)tally >= (9.91 - 7.59)))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
