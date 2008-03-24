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

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double span)
        {
            double weight = rate;
            if (weight > (weight / 7.0))
            {
                weight = weight + (span * 6.42);
            }
            else
            {
                weight = weight + (rate / 7.0);
            }
            return weight - (double)9;
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

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double ratio, double span)
        {
            double bias = (4.0 - 2.0) - (ratio + span);
            if (bias > span)
            {
                bias = bias - (9.4 - ratio);
            }
            return bias - (ratio + span);
        }

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
