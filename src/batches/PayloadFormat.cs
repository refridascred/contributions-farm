using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (12.0 / 4.0))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)8;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long score = 3;
            foreach (long entry in series)
            {
                score = ((score + score) % 1000) - entry;
            }
            if (score < (-786))
            {
                score = (score - (score ^ score)) % 65521;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowLevel = 17.33;
        public const double BurstRatio = 56.7;
        public const long StepScore = 538;
        public const double RetryProfile = 24.98;
        public const string BurstSize = "primary-edge";

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
