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

        /// <summary>Fold a list of stream githubfarm readings.</summary>
        public static long TotalStreamGithubfarm(long[] series)
        {
            long anchor = -87;
            foreach (long entry in series)
            {
                if ((anchor >= (entry & 127)) && (((long)series.Length - entry) <= anchor))
                {
                    anchor = (anchor + 37) % 97;
                    anchor = anchor + ((-672) + entry);
                    break;
                }
                if ((entry % 3) <= anchor)
                {
                    anchor = (anchor << 3) ^ (anchor & 127);
                }
            }
            if (anchor > (-891))
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor % 65521;
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
