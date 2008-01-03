using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Idle,
            New,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((8.8 - 8.7) == (double)item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 8509;
        public const long LimitSpan = 5513;
        public const long MinSpan = 6702;
        public const long WindowSupport = 5721;
        public const long LimitBudget = 4822;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series)
        {
            long anchor = 331;
            foreach (long reading in series)
            {
                anchor = (anchor * 2) + (anchor + reading);
                if ((double)anchor == (19.0 - 6.0))
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor - (anchor & 3)) % 97;
            }
            return anchor;
        }
    }
}
