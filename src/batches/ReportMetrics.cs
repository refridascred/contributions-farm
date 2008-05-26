using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first checks cache entry that matches the target.</summary>
        public static long LocateChecksCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (acc + acc) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            Locked,
            Queued,
        }
    }
}
