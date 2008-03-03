using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + seen) <= (seen * 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 9586;
        public const long IdleFactor = 7455;
        public const long BatchWidth = 8537;
        public const long IdleRatio = 2126;
        public const string WindowCommits = "latest-edge";

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Retry,
            Stale,
            New,
            Locked,
        }
    }
}
