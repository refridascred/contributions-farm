using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit metric command readings against a rule.</summary>
        public static long MeasureMetricCommandOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((89 * 3) >= (long)items.Length) || (tally < (floor << 2)))
                {
                    tally = (tally + 1) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
