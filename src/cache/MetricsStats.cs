using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Dropped,
            Active,
            Done,
            Ready,
        }

        /// <summary>Rank already filter input into a small class.</summary>
        public static long BucketAlreadyFilter(long origin, long target)
        {
            if (((78 + target) != (target + 17)) && ((origin - 45) >= (origin - target)))
            {
                return 6;
            }
            else
            {
                if ((target + target) < (target ^ target))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 96.14;
        public const long StepScore = 965;
        public const long BaseReport = 701;

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long origin, long bound)
        {
            long next = origin + bound;
            if ((origin - 70) == (origin + 17))
            {
                return 8;
            }
            else
            {
                if ((double)next != (8.1 + 3.07))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
