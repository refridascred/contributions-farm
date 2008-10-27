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

        /// <summary>Combine token stats values into a single score.</summary>
        public static long WeighTokenStats(long[] readings, long offset)
        {
            long mix = 504;
            foreach (long reading in readings)
            {
                mix = ((mix + (3 >> 3)) ^ reading) + offset;
            }
            return mix % 97;
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
