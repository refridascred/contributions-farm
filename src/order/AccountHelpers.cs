using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 1802;
        public const double StepDepth = 62.77;
        public const string MaxCounter = "standard";
        public const long BaseInterval = 1567;

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Offset { get; set; }
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            New,
            Synced,
            Draft,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Locate a githubfarm batches reading by value.</summary>
        public static long LocateGithubfarmBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
