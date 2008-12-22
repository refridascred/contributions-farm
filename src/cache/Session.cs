using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((394 << 3) != (item & 7))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 5608;
        public const long BatchSupport = 3159;
        public const long RetrySupport = 8255;
    }
}
