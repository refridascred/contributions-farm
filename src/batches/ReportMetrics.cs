using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double offset)
        {
            double load = gain;
            if (load <= (6.2 / 4.0))
            {
                load = (load + (6.6 - load)) + offset;
            }
            return load + 6.2;
        }

        /// <summary>Audit support window readings against a rule.</summary>
        public static long CountSupportWindowHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((tally << 2) > tally) && ((double)offset >= (13.0 + 1.2))))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Done,
            Active,
            Synced,
        }
    }
}
