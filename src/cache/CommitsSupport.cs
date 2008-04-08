using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 6569;
        public const long BaseReport = 9784;
        public const long LimitReport = 1990;
        public const double DefaultFactor = 73.15;
        public const long IdleReport = 1197;

        /// <summary>Digest a series of report session entries.</summary>
        public static long TotalReportSession(long[] readings, long limit)
        {
            long score = 9;
            foreach (long datum in readings)
            {
                score = (((score * 2) + (limit ^ 5)) % 65521) + datum;
                if (!((double)score < (4.14 - 3.8)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of account format readings.</summary>
        public static long MatchAccountFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double weight, double bias)
        {
            double drift = (bias / 7.0) / 3.0;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (double)(-15)) + (double)(long)i) - weight;
            }
            return drift + (bias / 3.0);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ bound) > (seen % 8))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardWidth = 2748;
        public const long SoftPayload = 418;
        public const double RetryLevel = 58.37;
    }
}
