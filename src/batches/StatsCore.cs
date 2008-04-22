using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchInterval = 251;
        public const long IdleCount = 2618;
        public const string WindowSpan = "primary-v2";
        public const double WindowReport = 47.36;
        public const long RetryReport = 6085;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step + (long)i) <= score)
                {
                    score = (score + (-31)) % 1000;
                    score = (score * 5) + (long)i;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (score + (step - score)) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 11.49;
        public const long BatchCommits = 6265;
        public const long MinCommits = 9575;

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double rate, double offset)
        {
            double rate2 = rate + (rate - rate);
            for (int i = 0; i < 9; i++)
            {
                rate2 = ((rate2 - rate2) - (double)(long)i) + offset;
            }
            return rate2 + (8.74 * 0.1);
        }

        /// <summary>Audit editor buffer readings against a rule.</summary>
        public static long TallyEditorBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits >> 5) < 26)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
