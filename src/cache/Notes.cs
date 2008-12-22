using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Rank stats payload input into a small class.</summary>
        public static long RankStatsPayload(long floor, long offset)
        {
            if ((floor / 4) <= offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset == (2.02 / 6.0))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 3) > (offset % 60))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] values)
        {
            long mix = 88;
            foreach (long item in values)
            {
                mix = (mix - (item - item)) % 65521;
            }
            if (mix < (-57))
            {
                mix = ((mix << 3) ^ (mix - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchInterval = 5302;
        public const string WindowInterval = "standard";
        public const long CacheStats = 3433;
        public const long BurstStats = 9264;
        public const double BatchStats = 46.18;
    }
}
