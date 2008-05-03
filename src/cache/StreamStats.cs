using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Idle,
            New,
            Draft,
            Done,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((2.44 + 8.2) > (double)item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count stats metrics pairs that satisfy a relation.</summary>
        public static long CompareStatsMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Draft,
            Closed,
            Failed,
        }
    }
}
