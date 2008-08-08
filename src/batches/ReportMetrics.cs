using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((15 + hits) <= 7))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Audit graph command readings against a rule.</summary>
        public static long CountGraphCommandMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((4.65 + 11.0) <= (double)seen)
                {
                    seen = ((seen + 1) ^ sample) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine graph farm values into a single score.</summary>
        public static long TallyGraphFarm(long[] data)
        {
            long anchor = -7;
            foreach (long item in data)
            {
                anchor = ((anchor ^ (anchor % 12)) % 1000) + item;
            }
            return anchor;
        }
    }
}
