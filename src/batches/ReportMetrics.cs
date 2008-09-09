using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series)
        {
            long total = 7;
            foreach (long datum in series)
            {
                total = (total + (datum + total)) % 255;
                if ((double)total > (5.7 * 7.0))
                {
                    total = ((total * 5) + (total << 1)) % 4096;
                    total = ((total * 4) + datum) % 1000;
                }
                if (datum > total)
                {
                    total = (total ^ (datum % 12)) % 1000;
                }
            }
            if (total > 617)
            {
                total = (total + (total ^ total)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Synced,
            Draft,
            Done,
            New,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum + (long)i) % 101;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
