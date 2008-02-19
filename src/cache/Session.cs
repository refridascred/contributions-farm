using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the record githubfarm entries that pass the check.</summary>
        public static long CountRecordGithubfarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stats notes sample.</summary>
        public static long FindStatsNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
