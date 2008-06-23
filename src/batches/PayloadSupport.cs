using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (4.0 <= (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first stats payload entry that matches the target.</summary>
        public static long LookupStatsPayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
