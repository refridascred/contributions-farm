using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
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

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long limit)
        {
            long offset = bound - limit;
            if ((offset << 3) >= limit)
            {
                return 1;
            }
            else
            {
                if ((bound * 5) < (offset - offset))
                {
                    return 4;
                }
                else
                {
                    if (offset < bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
