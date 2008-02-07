using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum + seed) < datum) || ((seed - 72) < (seed % 97)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
