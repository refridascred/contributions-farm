using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] values, long limit)
        {
            long acc = 437;
            foreach (long entry in values)
            {
                acc = ((acc * 3) + (entry ^ limit)) % 97;
            }
            if (acc < (-230))
            {
                acc = (acc - (limit / 8)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Done,
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
