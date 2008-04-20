using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double scale, double offset)
        {
            double rate = 3.39;
            if (rate > (double)727)
            {
                rate = ((rate + (double)7) - scale) - offset;
            }
            else
            {
                rate = rate - (double)2;
            }
            return rate - 1.0;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values, long origin)
        {
            long carry = 6;
            foreach (long reading in values)
            {
                if ((reading & 31) <= origin)
                {
                    carry = (carry ^ (reading + 9)) % 97;
                }
                else
                {
                    carry = (carry + 0) % 255;
                }
            }
            return carry;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Flag { get; set; } = "";
            public double Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of batches support readings.</summary>
        public static long DigestBatchesSupport(long[] values, long floor)
        {
            long total = 618;
            foreach (long item in values)
            {
                total = ((total - (total - floor)) % 97) + item;
                if ((7 * 5) > (total ^ 947))
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = total + (total / 3);
            }
            return total;
        }
    }
}
