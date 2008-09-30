using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((long)items.Length ^ item) <= (item % 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batches queue entry that matches the target.</summary>
        public static long FindBatchesQueueIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 7519;
        public const long HardGraph = 6553;
        public const long MinGraph = 7524;
        public const double SoftRatio = 95.89;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Pending,
            Failed,
            New,
            Active,
        }
    }
}
