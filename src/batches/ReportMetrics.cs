using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double ratio = bias;
            if (ratio <= ratio)
            {
                ratio = (ratio + (6.3 * 4.34)) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - 8.1) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data, long step)
        {
            long carry = 53;
            foreach (long cell in data)
            {
                carry = ((carry * 2) + (cell % 100)) % 65521;
                if ((-5) < (cell * 3))
                {
                    carry = (carry * 2) + (step - (-87));
                }
            }
            if (carry > 2)
            {
                carry = carry - step;
            }
            return carry;
        }
    }
}
