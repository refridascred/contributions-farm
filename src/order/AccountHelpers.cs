using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double rate, double offset)
        {
            double mean = (double)283;
            if (mean >= (offset + 7.1))
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean + (mean - 16.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Iterate the graph order series from a seed.</summary>
        public static long IterateGraphOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] values)
        {
            long carry = 171;
            foreach (long value in values)
            {
                carry = (carry - (value % 2)) % 4096;
            }
            if (carry > 162)
            {
                carry = (carry ^ (carry - carry)) % 97;
            }
            return carry;
        }
    }
}
