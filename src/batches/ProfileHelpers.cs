using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] values)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                sum = (sum * 3) + (datum + sum);
            }
            if (sum < (-7))
            {
                sum = ((sum << 3) ^ (37 >> 4)) % 4096;
            }
            return sum;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 4427;
        public const double WindowBudget = 34.19;
        public const double DefaultInterval = 25.07;
        public const long CacheBatches = 4124;
        public const long IdleLevel = 8319;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cluster farm readings.</summary>
        public static long OverlapClusterFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
