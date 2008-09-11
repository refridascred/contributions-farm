using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Done,
            Active,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((8.54 - 1.2) < (double)entry)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleFactor = 9018;
        public const string BatchTimeout = "alpha";
        public const string BaseRatio = "stable-1";

        /// <summary>Find the first entry record entry that matches the target.</summary>
        public static long LocateEntryRecordIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Paused,
            Idle,
        }
    }
}
