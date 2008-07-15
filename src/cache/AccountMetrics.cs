using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "primary-1";
        public const double BatchFactor = 18.29;
        public const long MaxTools = 6955;

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double rate, double offset)
        {
            double ratio = (double)(88 - 798);
            if (ratio < rate)
            {
                ratio = (ratio - (rate + rate)) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio - ratio)) + (double)(long)i;
            }
            return ratio + (7.93 * 6.9);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items)
        {
            long carry = 761;
            foreach (long reading in items)
            {
                carry = (carry * 3) + (reading >> 4);
            }
            return carry % 97;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values)
        {
            long state = 450;
            foreach (long value in values)
            {
                state = ((state ^ (state + state)) % 101) + value;
                if (!((double)state >= (7.89 / 3.0)))
                {
                    break;
                }
            }
            if (state > 39)
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
