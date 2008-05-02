using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples)
        {
            long carry = 923;
            foreach (long reading in samples)
            {
                carry = ((carry << 2) ^ (4 % 64)) - reading;
                carry = (carry ^ 136) % 255;
            }
            return carry;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry << 2) ^ (carry + carry)) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = ((score << 3) ^ ((long)i >> 2)) % 65521;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double floor)
        {
            double mean = (double)7 / 6.0;
            if (mean <= mean)
            {
                mean = ((mean - (mean - mean)) + weight) + floor;
            }
            return mean - mean;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits <= (hits - floor))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
