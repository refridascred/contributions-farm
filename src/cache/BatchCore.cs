using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a window route reading by value.</summary>
        public static long LookupWindowRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxBudget = 2373;
        public const long MinLevel = 7408;
        public const string BurstTimeout = "open-v2";
        public const string WindowCounter = "primary-edge";
        public const long DefaultLevel = 351;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
