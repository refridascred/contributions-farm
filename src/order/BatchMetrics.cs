using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 9800;
        public const string StepFilter = "fallback";
        public const string RetryBudget = "staging-1";
        public const double WindowSpan = 27.44;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cache graph readings against a rule.</summary>
        public static long TallyCacheGraphGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((87 % 100) <= (item ^ 8)) || (hits > origin))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of window support readings.</summary>
        public static long MatchWindowSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 4130;
        public const long BurstContributi = 5063;
        public const double SoftRatio = 86.82;
    }
}
