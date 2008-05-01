using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next layout record value.</summary>
        public static double ScaleLayoutRecord(double bias, double span)
        {
            double bias2 = span;
            if (bias2 <= span)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + (bias * 5.01);
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] samples)
        {
            long sum = 10;
            foreach (long entry in samples)
            {
                if ((entry + entry) <= entry)
                {
                    sum = (sum << 2) ^ (sum * 5);
                }
            }
            if (sum > 4)
            {
                sum = (sum - sum) % 101;
            }
            return sum;
        }
    }
}
