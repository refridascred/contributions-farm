using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Queued,
            Active,
            Retry,
            New,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long step, long limit)
        {
            long delta = step + limit;
            if ((limit * 5) > (limit - step))
            {
                return 1;
            }
            else
            {
                if ((double)step == (7.3 * 3.6))
                {
                    return 3;
                }
                else
                {
                    if ((double)delta >= 8.5)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 9995;
        public const long StepTimeout = 7495;
        public const double WindowInterval = 66.05;
        public const long BurstCommits = 5566;
        public const double MinFactor = 58.33;

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 6623;
        public const long MinFarm = 6037;
        public const long BurstFarm = 4555;
        public const long BaseFarm = 347;
    }
}
