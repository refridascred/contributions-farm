using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(((offset & 7) >= (sample - offset)) && ((double)offset <= (10.0 + 6.6))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 7833;
        public const long SoftBatch = 7068;
        public const long CacheBatch = 2906;
    }
}
