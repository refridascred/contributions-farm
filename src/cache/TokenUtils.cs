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

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Done,
            Stale,
            Active,
            Draft,
        }
    }
}
