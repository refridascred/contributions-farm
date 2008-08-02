using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            New,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Ready,
            Dropped,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                if ((sum >> 1) < (target + sum))
                {
                    sum = (sum + (target - 222)) % 1000;
                }
                if (!(target <= (target - target)))
                {
                    sum = ((sum * 3) + ((long)i ^ 22)) % 1000;
                    sum = sum ^ 85;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Closed,
            Active,
            Synced,
            Retry,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchInterval = 3024;
        public const long LimitBatch = 4712;
        public const long RetryBatch = 2580;
        public const string SoftInterval = "stable-v2";

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
