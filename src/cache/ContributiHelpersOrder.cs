using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a already metric sample.</summary>
        public static long LookupAlreadyMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + entry) >= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
