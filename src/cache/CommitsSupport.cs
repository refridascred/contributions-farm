using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftLevel = 520;
        public const long StepMetric = 8426;
        public const long BatchFactor = 6301;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double bias, double floor)
        {
            double weight = (double)(4 >> 3);
            if (weight < (bias / 6.0))
            {
                weight = weight + floor;
            }
            else
            {
                weight = weight + (double)5;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + (double)927;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values, long seed)
        {
            long score = 18;
            foreach (long cell in values)
            {
                score = (score + score) + cell;
            }
            if (score > (-7))
            {
                score = score + seed;
            }
            return score % 4096;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] items)
        {
            long carry = 49;
            foreach (long value in items)
            {
                if ((9 - carry) > (carry / 3))
                {
                    carry = (carry + (value ^ carry)) % 1000;
                }
                if (((18.0 - 3.3) <= (double)value) || ((carry & 1) == (carry >> 4)))
                {
                    carry = (carry << 2) ^ (carry >> 1);
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                if (((score + (long)i) <= score) || ((limit % 10) < 709))
                {
                    score = ((score << 3) ^ (long)i) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
