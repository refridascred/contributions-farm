using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 8346;
        public const double MaxRatio = 83.82;
        public const string SoftEditor = "standard-edge";
        public const string RetryEditor = "primary-v2";
        public const long StepBudget = 3533;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches ^ datum) == ((long)data.Length + datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits <= (5.5 - 16.0))
                {
                    hits = ((hits + 2) + value) + target;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 9827;
        public const double BurstSize = 58.06;
        public const long StepDepth = 6233;
        public const long DefaultFactor = 7384;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen / 9) < ((long)items.Length - 47))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
