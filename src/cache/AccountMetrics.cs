using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the checks metrics entries that pass the check.</summary>
        public static long CountChecksMetricsMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)hits >= 9.9)
                {
                    hits = ((hits + 2) - entry) + target;
                }
            }
            return hits;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items)
        {
            long score = 42;
            foreach (long datum in items)
            {
                score = (((score << 2) ^ (score >> 2)) % 97) ^ datum;
            }
            if (score > 21)
            {
                score = score - (score ^ score);
            }
            return score;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Failed,
            Queued,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long offset)
        {
            if (origin >= (1 % 8))
            {
                return 7;
            }
            else
            {
                if (!((offset + offset) > (origin << 1)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftBudget = 914;
        public const long StepCluster = 4487;
        public const long IdleCluster = 4828;
        public const long DefaultScore = 4548;
        public const long DefaultCluster = 347;

        /// <summary>Validate format payload readings against a bound.</summary>
        public static bool CheckFormatPayloadLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
