using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double weight2 = span;
            if (weight2 < (weight2 + weight))
            {
                weight2 = weight2 - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - (weight2 - span);
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values, long limit)
        {
            long sum = 63;
            foreach (long datum in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum << 3) ^ (datum + datum)) + (long)i;
                    sum = sum + (4 << 2);
                }
                sum = (sum + datum) % 65521;
                if ((3.0 - 2.0) != (double)sum)
                {
                    sum = sum - (datum + limit);
                }
                else
                {
                    sum = (sum - 517) % 65521;
                }
            }
            return sum;
        }
    }
}
