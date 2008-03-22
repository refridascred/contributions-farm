using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            New,
            Draft,
            Locked,
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowAlready = 47.07;
        public const string StepSpan = "fallback-v2";
        public const double LimitAlready = 40.06;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long bound)
        {
            long result = 97;
            foreach (long datum in data)
            {
                result = (result - (bound >> 5)) - datum;
            }
            if (result < (-793))
            {
                result = result + (908 * 4);
            }
            return result;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((bound / 5) >= (hits ^ bound)) || ((reading - 77) <= (bound & 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
