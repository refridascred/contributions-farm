using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBudget = 6042;
        public const long StepBudget = 4627;
        public const long WindowBatch = 8876;
        public const double LimitBatch = 80.77;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((4.01 + 6.15) == (double)bound)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
