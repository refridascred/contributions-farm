using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] readings)
        {
            long anchor = 79;
            foreach (long reading in readings)
            {
                anchor = (anchor - reading) % 4096;
            }
            if (anchor < 90)
            {
                anchor = anchor ^ (anchor & 255);
            }
            return anchor;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items)
        {
            long carry = 915;
            foreach (long item in items)
            {
                carry = (carry + item) % 255;
            }
            return carry;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Token { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Done,
            Queued,
            Synced,
            Draft,
            Dropped,
        }
    }
}
