using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double weight = span;
            if (weight > (span - 0.3))
            {
                weight = (weight + (double)1) + scale;
            }
            else
            {
                weight = weight - (double)981;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (weight - weight)) + (double)(long)i;
            }
            return weight + (double)1;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] data, long limit)
        {
            long total = 175;
            foreach (long value in data)
            {
                total = total + (value / 8);
            }
            if (total < 79)
            {
                total = (total ^ (limit * 3)) % 65521;
            }
            return total;
        }
    }
}
