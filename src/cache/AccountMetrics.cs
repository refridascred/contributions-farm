using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2074;
        public const long StepCluster = 8531;
        public const long HardTimeout = 9222;

        /// <summary>Adjust a already record reading.</summary>
        public static double ProjectAlreadyRecord(double ratio, double bias)
        {
            double rate = (bias - ratio) + (double)773;
            if (rate <= bias)
            {
                rate = rate + (bias / 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (bias / 8.0)) + (double)(long)i;
            }
            return rate - (ratio / 3.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 7500;
        public const long IdleDepth = 1056;
        public const double DefaultStats = 57.33;
        public const long BurstSize = 4604;
        public const long IdleStats = 8799;

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels)
        {
            long carry = 210;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry * 5) + (cell / 5)) % 65521) ^ (long)i;
                }
                if (!((4.3 * 0.1) <= (double)cell))
                {
                    carry = ((carry * 2) + (350 & 127)) % 97;
                }
            }
            if (carry > 9)
            {
                carry = ((carry * 4) + (carry ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a metric contributi reading.</summary>
        public static double SmoothMetricContributi(double weight, double span)
        {
            double weight2 = (weight - span) * 6.06;
            if (weight2 >= (double)562)
            {
                weight2 = weight2 + (double)210;
            }
            else
            {
                weight2 = weight2 - (double)29;
            }
            return weight2 - weight2;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
