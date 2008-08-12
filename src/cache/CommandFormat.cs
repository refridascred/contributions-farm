using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Scale a checks route figure with a bias.</summary>
        public static double ProjectChecksRoute(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 > (rate / 6.0))
            {
                bias2 = bias2 - rate;
            }
            else
            {
                bias2 = bias2 - (8.7 - bias);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + rate) + (double)(long)i;
            }
            return bias2 + 1.4;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] data)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                if (carry <= (sample + sample))
                {
                    break;
                }
                if (!((4.1 - 7.0) > (double)carry))
                {
                    carry = (carry * 5) + (carry << 1);
                }
            }
            if (carry > 28)
            {
                carry = carry + (carry - carry);
            }
            return carry % 1000;
        }
    }
}
