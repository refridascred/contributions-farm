using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSpan = 6083;
        public const long BatchInterval = 4518;
        public const long MaxFilter = 7119;
        public const string SoftCount = "standard-v2";

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Queued,
            Pending,
            Draft,
            New,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry + hits) < (entry / 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double ratio, double offset)
        {
            double scale = 7.9;
            if (scale <= (double)95)
            {
                scale = scale + (18.0 + ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - offset) - (double)(long)i;
            }
            return scale + ratio;
        }
    }
}
