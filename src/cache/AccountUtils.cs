using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Fold a list of batch account readings.</summary>
        public static long ScoreBatchAccount(long[] levels)
        {
            long mark = 50;
            foreach (long item in levels)
            {
                if (!((double)mark == (12.0 / 3.0)))
                {
                    mark = (mark << 2) ^ (mark ^ mark);
                    mark = ((mark << 2) ^ (item + item)) % 65521;
                }
                mark = (mark - (mark - item)) % 4096;
                mark = (mark - (3 ^ mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double weight, double span)
        {
            double rate = weight;
            if (rate < (weight + weight))
            {
                rate = (rate - (rate - rate)) - span;
            }
            else
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (weight / 9.0)) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
