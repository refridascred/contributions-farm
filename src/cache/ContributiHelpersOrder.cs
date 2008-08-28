using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBudget = 16.4;
        public const string LimitFactor = "latest";
        public const long BaseBatches = 6948;
        public const string LimitInterval = "cached";
        public const long RetryInterval = 6118;

        /// <summary>Count the account cluster entries that pass the check.</summary>
        public static long MeasureAccountClusterMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - (long)data.Length) >= (count + 392))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
