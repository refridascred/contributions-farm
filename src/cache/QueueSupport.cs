using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count % 5) >= (0 - count))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Locate a editor entry reading by value.</summary>
        public static long FindEditorEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((12.0 * 7.0) == (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
