using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Pending,
            Queued,
            Stale,
            Closed,
        }

        /// <summary>Count commits filter pairs that satisfy a relation.</summary>
        public static long PairCommitsFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset + acc) == (acc << 2))
                {
                    continue;
                }
                else
                {
                    acc = acc - offset;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public double Limit { get; set; }
        }
    }
}
