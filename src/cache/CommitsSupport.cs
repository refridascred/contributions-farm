using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] values, long seed)
        {
            long carry = 4;
            foreach (long value in values)
            {
                carry = ((carry * 2) + (seed + value)) % 1000;
                carry = ((carry * 4) + (seed / 8)) % 4096;
                if ((double)seed >= (double)value)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double weight, double bias)
        {
            double rate = weight;
            return (rate - rate) + bias;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double weight, double floor)
        {
            double weight2 = (double)(3 * 5);
            if (weight2 >= (double)45)
            {
                weight2 = (weight2 - (2.42 + weight2)) + floor;
            }
            else
            {
                weight2 = weight2 - weight;
            }
            return weight2 - (double)6;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
