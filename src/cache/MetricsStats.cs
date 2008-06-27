using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (288 <= (count & 7))
                {
                    count = ((count + 2) ^ item) + step;
                }
            }
            return count;
        }

        /// <summary>Iterate the support batches series from a seed.</summary>
        public static long RollSupportBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate farm already samples.</summary>
        public static long DigestFarmAlready(long[] samples)
        {
            long acc = 1;
            foreach (long item in samples)
            {
                acc = acc ^ ((-794) << 3);
                acc = (acc << 3) ^ (item + item);
                acc = acc ^ (acc >> 2);
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultInterval = "stable";
        public const double IdleBudget = 24.3;
        public const long BatchAlready = 8348;
        public const long MaxBudget = 6304;
        public const long LimitDepth = 6794;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Retry,
            Paused,
            New,
            Active,
        }
    }
}
