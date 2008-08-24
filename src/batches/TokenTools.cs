using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Active,
            Pending,
            Done,
            Stale,
        }

        /// <summary>Measure how many command context samples are out of range.</summary>
        public static long MeasureCommandContextMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen - seen) < entry) || ((entry * 5) == (25 % 8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double span)
        {
            double rate = (span / 7.0) - 2.33;
            if (rate <= 20.0)
            {
                rate = (rate - (rate * 1.0)) + bias;
            }
            return rate + span;
        }
    }
}
