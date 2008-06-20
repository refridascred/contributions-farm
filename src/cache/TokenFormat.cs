using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits <= (9.5 - 7.0))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell * 3) < (3 & 15))
                {
                    tally = (tally + 2) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
