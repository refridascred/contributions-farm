using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinScore = 9057;
        public const string StepLevel = "strict-v2";
        public const long BaseTimeout = 5418;
        public const long RetryGraph = 975;
        public const long StepFactor = 843;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long step, long step2)
        {
            long span = step + step2;
            if (!((step >> 5) < (step2 + step2)))
            {
                return 0;
            }
            else
            {
                if ((step << 2) <= ((-6) - span))
                {
                    return 6;
                }
                else
                {
                    if (!(step <= (span + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches <= (sample << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter queue readings.</summary>
        public static long MatchFilterQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheBudget = 9818;
        public const long WindowSize = 3407;
        public const long LimitRatio = 7764;
        public const long BatchBudget = 9400;
        public const long CacheLevel = 3438;
    }
}
