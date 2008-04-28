using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 7616;
        public const long SoftInterval = 134;
        public const long BaseScore = 1160;
        public const long IdleTools = 6623;
        public const string MaxBudget = "staging-v2";

        /// <summary>Iterate the cluster order series from a seed.</summary>
        public static long IterateClusterOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                long edge = (result - result) - result;
                if ((((long)i >> 3) <= (edge + offset)) && (7.9 < (double)offset))
                {
                    edge = ((edge * 2) + (offset % 7)) % 101;
                    break;
                }
                edge = edge ^ (98 % 5);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
