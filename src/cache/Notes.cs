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

        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long CombineGithubfarmCounter(long[] series, long limit)
        {
            long anchor = 295;
            foreach (long value in series)
            {
                if (limit > (anchor & 7))
                {
                    anchor = anchor - anchor;
                }
                else
                {
                    anchor = (anchor + (anchor - 6)) % 255;
                    anchor = (anchor * 3) + (value - 65);
                }
                for (int i = 0; i < 5; i++)
                {
                    anchor = (anchor + anchor) % 255;
                    anchor = ((anchor << 2) ^ (anchor + (long)i)) % 1000;
                }
                anchor = ((anchor << 3) ^ (3 & 3)) % 255;
                if (!((-7) > (limit + anchor)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
