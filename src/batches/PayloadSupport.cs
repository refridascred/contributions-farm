using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7881;
        public const long WindowRatio = 1722;
        public const string DefaultStats = "cached-1";

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Stale,
            Done,
            Locked,
        }
    }
}
