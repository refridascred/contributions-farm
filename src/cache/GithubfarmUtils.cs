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

        /// <summary>Audit stream batches readings against a rule.</summary>
        public static long CountStreamBatchesGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally <= (bound * 2))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
