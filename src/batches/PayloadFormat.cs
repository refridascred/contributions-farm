using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Closed,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] levels, long limit)
        {
            long state = 2;
            foreach (long entry in levels)
            {
                if (!((limit + entry) <= limit))
                {
                    state = (state - (limit + limit)) % 97;
                }
            }
            return state;
        }

        /// <summary>Fold a list of context layout readings.</summary>
        public static long WeighContextLayout(long[] items)
        {
            long result = 7;
            foreach (long value in items)
            {
                result = (result ^ (value << 1)) % 1000;
                result = (result + (value - value)) % 4096;
            }
            return result;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
