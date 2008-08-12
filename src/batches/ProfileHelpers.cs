using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((((hits + (long)readings.Length) <= reading) || (((-2) % 2) >= reading)) && (((hits - 760) < (reading + hits)) && ((reading >> 3) <= (66 << 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Count filter commits pairs that satisfy a relation.</summary>
        public static long MatchFilterCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((((long)items.Length + count) < count) && ((cell * 5) != (count << 3))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a metrics session reading.</summary>
        public static double SmoothMetricsSession(double weight, double span)
        {
            double mean = span;
            if (mean <= (weight + weight))
            {
                mean = mean + span;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean + (double)(-91);
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Ready,
            Active,
            Dropped,
            Done,
        }
    }
}
