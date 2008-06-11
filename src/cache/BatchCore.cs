using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell / 4) != ((-480) & 255))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((9.1 * 18.0) < (double)entry)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit tools editor readings against a rule.</summary>
        public static long MeasureToolsEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((seen * 5) >= (62 & 3)) || ((seen >> 4) < value)) || ((seen > (seen + value)) && ((value * 2) >= (seen * 5))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
