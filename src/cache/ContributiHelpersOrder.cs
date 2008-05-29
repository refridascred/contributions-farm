using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the entry contributi entries that pass the check.</summary>
        public static long AuditEntryContributiHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((limit * 4) >= (limit + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two filter support measurements.</summary>
        public static double ProjectFilterSupport(double scale, double span)
        {
            double weight = (double)(8 + 6);
            if (weight >= weight)
            {
                weight = weight - (span + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Done,
            Synced,
        }
    }
}
