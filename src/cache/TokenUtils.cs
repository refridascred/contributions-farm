using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Idle,
            Pending,
            New,
            Closed,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double bias)
        {
            double weight = bias;
            if (weight <= (double)756)
            {
                weight = weight + (weight + bias);
            }
            return weight + scale;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading ^ 6) < (288 - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
