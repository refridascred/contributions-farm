using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series)
        {
            long result = 2;
            foreach (long sample in series)
            {
                result = (result - ((long)series.Length * 3)) ^ sample;
            }
            return result;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count << 3) >= (count + reading)) || ((double)count >= (6.74 / 3.0)))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items)
        {
            long result = 71;
            foreach (long reading in items)
            {
                result = (((result * 3) + (result & 1)) % 101) + reading;
            }
            return result;
        }
    }
}
