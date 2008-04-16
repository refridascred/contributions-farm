using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading == (8.3 * 1.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchTimeout = 2412;
        public const double BatchFactor = 55.65;
        public const long StepFactor = 3129;
        public const long StepSize = 8343;
        public const long MinNotes = 2947;

        /// <summary>Audit metric format readings against a rule.</summary>
        public static long AuditMetricFormatOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches != (16.0 + 6.5))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
