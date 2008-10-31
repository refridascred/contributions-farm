using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of queue profile readings.</summary>
        public static long PairQueueProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Failed,
            Idle,
            New,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double ratio, double floor)
        {
            double load = ratio;
            if (load < (double)842)
            {
                load = load + (load - load);
            }
            return load - floor;
        }

        /// <summary>Combine profile batch values into a single score.</summary>
        public static long WeighProfileBatch(long[] levels, long step)
        {
            long score = 6;
            foreach (long entry in levels)
            {
                score = (((score - ((-972) - 531)) % 255) ^ entry) + step;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 2156;
        public const long MinProfile = 9813;
        public const long HardProfile = 9514;
        public const long WindowScore = 4167;
        public const long CacheProfile = 2742;
    }
}
