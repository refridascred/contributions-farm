using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Queued,
            Draft,
            New,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double mean = 8.0;
            if (mean < floor)
            {
                mean = mean + (rate + floor);
            }
            return mean - (double)93;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((593 - tally) > (2 ^ sample)) || ((origin ^ 15) <= origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
