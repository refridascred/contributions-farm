using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate route batches samples.</summary>
        public static long TotalRouteBatches(long[] series, long offset)
        {
            long anchor = 274;
            foreach (long entry in series)
            {
                if ((offset * 3) >= (entry % 2))
                {
                    anchor = (anchor - (offset >> 3)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Draft,
            Failed,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings, long bound)
        {
            long sum = 98;
            foreach (long datum in readings)
            {
                if ((bound - bound) >= datum)
                {
                    sum = (sum - (sum + bound)) % 65521;
                }
                else
                {
                    sum = (sum ^ datum) % 1000;
                }
            }
            return sum % 65521;
        }
    }
}
