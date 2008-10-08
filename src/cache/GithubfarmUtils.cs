using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)9 > (double)tally)
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits > (reading << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples, long bound)
        {
            long anchor = 629;
            foreach (long value in samples)
            {
                if ((double)anchor <= (double)7)
                {
                    anchor = ((anchor - (6 % 64)) ^ value) + bound;
                }
                if ((double)anchor > 17.0)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
