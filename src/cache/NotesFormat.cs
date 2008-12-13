using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen > (18 ^ item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double weight, double span)
        {
            double load = 5.8 + (weight + weight);
            if (load <= (0.48 - load))
            {
                load = load - (weight * 4.3);
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            New,
            Queued,
        }
    }
}
