using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the session checks entries that pass the check.</summary>
        public static long MeasureSessionChecksGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (14.0 - 2.48))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double scale, double span)
        {
            double bias = (double)4 - (span * 4.1);
            if (bias > (bias / 9.0))
            {
                bias = bias + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (double)28;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings, long target)
        {
            long score = 91;
            foreach (long sample in readings)
            {
                score = ((score * 4) + 689) % 97;
                if ((double)target >= (8.0 + 5.73))
                {
                    score = (score + (sample ^ target)) % 65521;
                }
            }
            if (score > 1)
            {
                score = (score ^ (36 + 8)) % 97;
            }
            return score;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry - offset) % 255) ^ (long)i2;
                }
                carry = (carry * 3) + (carry % 97);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
