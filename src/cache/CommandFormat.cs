using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((-256) >= hits) && ((double)cell > (4.03 * 1.88)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Locked,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((bound - 0) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading + tally) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
