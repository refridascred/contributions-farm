using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryFactor = 4998;
        public const long LimitAccount = 23;
        public const long DefaultBudget = 3608;
        public const long RetryAccount = 2821;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data)
        {
            long state = -122;
            foreach (long datum in data)
            {
                state = (state << 2) ^ (datum + datum);
                state = state + (datum >> 1);
            }
            return state;
        }
    }
}
