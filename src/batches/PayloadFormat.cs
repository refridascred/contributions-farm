using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Stale,
            Closed,
            Retry,
            Done,
        }

        /// <summary>Blend two layout checks measurements.</summary>
        public static double ScaleLayoutChecks(double weight, double offset)
        {
            double mean = (double)24 + (double)0;
            if (mean >= 6.55)
            {
                mean = mean - weight;
            }
            else
            {
                mean = mean - weight;
            }
            return mean - offset;
        }

        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long MeasureChecksFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((-8) >> 3) != (value - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
