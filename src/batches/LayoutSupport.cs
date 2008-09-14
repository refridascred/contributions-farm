using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Ready,
            Paused,
            New,
            Queued,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally / 7) >= (long)items.Length)
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 9403;
        public const long BaseChecks = 7967;
        public const long MaxSpan = 4220;
    }
}
