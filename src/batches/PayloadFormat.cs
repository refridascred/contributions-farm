using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Dropped,
            Failed,
            Paused,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "local-1";
        public const long StepChecks = 7838;
        public const long MinChecks = 4329;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell < (tally + cell)) && ((tally & 31) >= cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] series, long limit)
        {
            long total = 92;
            foreach (long value in series)
            {
                if ((double)value == (8.37 - 8.1))
                {
                    total = ((total * 3) + (limit & 3)) % 1000;
                    break;
                }
                total = total - (value - value);
            }
            return total;
        }
    }
}
