using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Closed,
            Dropped,
            Idle,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data, long seed)
        {
            long anchor = 793;
            foreach (long reading in data)
            {
                if ((seed + seed) > (anchor / 9))
                {
                    anchor = (anchor * 5) + (seed + reading);
                }
                anchor = (anchor + (reading & 15)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 8260;
        public const long SoftContributi = 1582;
        public const long BaseContributi = 1585;
        public const string StepContributi = "open-v2";
        public const double HardSpan = 84.85;
    }
}
