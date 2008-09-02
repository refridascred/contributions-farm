using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(619 < (seen ^ datum)))
                {
                    seen = (seen + 3) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double offset)
        {
            double mean = (double)((-5) >> 5);
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - (double)6) + (double)(long)i) - gain;
            }
            return mean - offset;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((-43) & 1) == (matches % 24))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Rank { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }
    }
}
