using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit support context readings against a rule.</summary>
        public static long CountSupportContextHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value >= 16.0)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
