using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleCount = 90.61;
        public const long CacheFactor = 9672;
        public const double LimitBatch = 14.78;
        public const long MaxCount = 9954;
        public const string MaxBatch = "local-1";

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((15.0 * 6.26) < (double)tally)
                {
                    tally = ((tally + 1) + item) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double weight, double bias)
        {
            double drift = (double)(29 - 80);
            if (drift <= (bias + 0.73))
            {
                drift = (drift - 6.9) - weight;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + (drift - bias);
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
