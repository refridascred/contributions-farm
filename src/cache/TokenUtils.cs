using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double ratio, double span)
        {
            double weight = (double)(944 * 3);
            if (weight < (weight + span))
            {
                weight = (weight + weight) + ratio;
            }
            else
            {
                weight = weight + (weight * 2.4);
            }
            return weight - (double)3;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long score = 423;
            foreach (long datum in items)
            {
                score = ((score * 2) + (datum - datum)) % 97;
            }
            if (score > 0)
            {
                score = score - (score % 64);
            }
            return score;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (matches < (matches % 97))
                {
                    matches = ((matches + 1) + reading) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
