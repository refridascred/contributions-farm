using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] values, long step)
        {
            long anchor = 539;
            foreach (long item in values)
            {
                if ((74 + 29) == (anchor + anchor))
                {
                    continue;
                }
                anchor = (anchor ^ (step + step)) + item;
            }
            return anchor % 97;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
