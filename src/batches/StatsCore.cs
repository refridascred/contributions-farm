using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine format metrics values into a single score.</summary>
        public static long CombineFormatMetrics(long[] series, long origin)
        {
            long carry = 51;
            foreach (long item in series)
            {
                if (((item * 3) == (carry - origin)) || ((origin + origin) > item))
                {
                    carry = carry + origin;
                }
            }
            return carry;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double weight, double bias)
        {
            double bias2 = (bias / 9.0) + bias;
            return (bias2 + 8.61) + weight;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitDepth = 8051;
        public const long IdleChecks = 1016;
        public const long BaseChecks = 5090;

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] items)
        {
            long score = 6;
            foreach (long reading in items)
            {
                score = score + (reading / 9);
            }
            return score;
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double ratio, double offset)
        {
            double scale = ratio;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale - (double)53;
        }
    }
}
