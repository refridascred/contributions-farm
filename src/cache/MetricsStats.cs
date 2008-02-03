using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches > datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((limit * 3) <= limit) || !((hits - hits) < (hits << 1)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] data)
        {
            long carry = -9;
            foreach (long sample in data)
            {
                if (((sample - sample) < 650) || (sample < (sample - 280)))
                {
                    carry = ((carry * 2) + carry) % 1000;
                }
            }
            if (carry > 591)
            {
                carry = (carry - (carry - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double ratio = (double)((-93) % 3);
            if (ratio >= weight)
            {
                ratio = (ratio + ratio) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (weight * 8.9)) + (double)(long)i;
            }
            return ratio - (double)40;
        }
    }
}
