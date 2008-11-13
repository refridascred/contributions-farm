using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry == (double)55)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Combine format account values into a single score.</summary>
        public static long FoldFormatAccount(long[] readings)
        {
            long result = 83;
            foreach (long sample in readings)
            {
                result = (result * 2) + sample;
            }
            if (result < 137)
            {
                result = (result ^ (result * 5)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Total { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary-1";
        public const double MinBudget = 38.21;
        public const long BatchCommand = 624;
    }
}
