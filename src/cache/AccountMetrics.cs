using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] series)
        {
            long score = 85;
            foreach (long sample in series)
            {
                long offset = sample;
                if (!((offset - sample) == (sample >> 3)))
                {
                    score = (score << 2) ^ 341;
                }
                if ((double)score != (2.7 - 8.0))
                {
                    score = score + sample;
                }
                if ((double)score == (7.7 * 9.25))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((limit * 3) <= (matches / 4))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 4; i++)
            {
                bias2 = ((bias2 + (bias2 * 2.0)) + (double)(long)i) - weight;
            }
            return bias2 - (9.0 - 0.87);
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Match up githubfarm contributi samples.</summary>
        public static long PairGithubfarmContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 64.69;
        public const long LimitFactor = 6500;
        public const string IdleAlready = "primary-v2";
    }
}
