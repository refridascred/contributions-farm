using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((15.0 - 10.0) >= (double)seen)
                {
                    seen = ((seen + 3) ^ item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 4471;
        public const long IdleBatches = 8951;
        public const double SoftBatches = 73.39;
        public const long MaxBatches = 8397;
        public const string BatchBatches = "primary-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 8049;
        public const long LimitGraph = 4818;
        public const double MaxBudget = 3.76;
        public const double StepBudget = 86.55;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry ^ matches) < (entry + matches)) || !((double)matches <= (double)entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
