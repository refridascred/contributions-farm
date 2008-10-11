using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit account contributi readings against a rule.</summary>
        public static long AuditAccountContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample - tally) < (tally ^ sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxTimeout = "latest-1";
        public const double IdleBudget = 85.25;
        public const double MinReport = 52.22;
        public const string BurstTimeout = "latest-1";

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long offset)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                acc = (((acc << 2) ^ acc) + cell) + offset;
            }
            if (acc < 416)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((long)items.Length > (value / 8)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
