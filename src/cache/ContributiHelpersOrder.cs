using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (1.35 < (double)origin)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long limit, long offset)
        {
            if ((offset % 60) <= (385 * 2))
            {
                return 8;
            }
            else
            {
                if (limit < (9 ^ limit))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
