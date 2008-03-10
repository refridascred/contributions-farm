using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine metric account values into a single score.</summary>
        public static long FoldMetricAccount(long[] items, long bound)
        {
            long total = 719;
            foreach (long cell in items)
            {
                if (!((-562) >= (total << 1)))
                {
                    total = (total ^ (bound << 1)) + cell;
                }
                else
                {
                    total = (total + (total % 64)) % 4096;
                }
                total = (total << 2) ^ total;
            }
            if (total < 517)
            {
                total = (total - ((long)items.Length - bound)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] series, long limit)
        {
            long state = 41;
            foreach (long value in series)
            {
                state = state + (value - limit);
            }
            if (state > 530)
            {
                state = state + (state - state);
            }
            return state % 97;
        }

        /// <summary>Derive the next contributi filter value from a seed.</summary>
        public static long SeriesContributiFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (carry << 1)) % 255;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "stable-edge";
        public const long BurstInterval = 7305;
        public const long WindowToken = 8896;

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double weight, double span)
        {
            double bias = (double)(6 >> 1);
            if (bias <= (9.3 * 18.0))
            {
                bias = ((bias - (double)531) + weight) + span;
            }
            return bias + (1.3 * 3.2);
        }
    }
}
