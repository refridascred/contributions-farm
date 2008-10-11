using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry < (133 - entry))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Draft,
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleSize = 29.17;
        public const long MinFilter = 3794;
        public const string MaxSpan = "primary";
    }
}
