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

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] series, long limit)
        {
            long acc = -187;
            foreach (long reading in series)
            {
                if (limit < (reading << 2))
                {
                    acc = ((acc * 3) + (reading / 7)) % 1000;
                }
                acc = (acc * 5) + (acc & 255);
            }
            if (acc > 37)
            {
                acc = (acc ^ (limit & 127)) % 97;
            }
            return acc;
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
