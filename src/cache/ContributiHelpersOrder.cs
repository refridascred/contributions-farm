using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items)
        {
            long total = 12;
            foreach (long sample in items)
            {
                total = (total + (sample << 2)) % 101;
                total = (total + (sample + total)) % 97;
            }
            return total;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Draft,
            New,
            Locked,
            Pending,
        }

        /// <summary>Audit context cluster readings against a rule.</summary>
        public static long CountContextClusterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((8.0 / 5.0) == (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
