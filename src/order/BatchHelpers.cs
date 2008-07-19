using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels, long seed)
        {
            long carry = 98;
            foreach (long value in levels)
            {
                if (((seed + 46) <= carry) && ((carry + (-630)) <= (value + 62)))
                {
                    carry = carry + (seed + carry);
                    continue;
                }
                carry = carry ^ 0;
                if (((-88) * 5) != (seed >> 4))
                {
                    carry = carry + (carry * 3);
                }
                else
                {
                    carry = carry - (carry / 5);
                }
                if (!(carry >= (carry + value)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double ratio = rate;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (double)96) + (double)(long)i) + span;
            }
            return ratio + (ratio / 7.0);
        }
    }
}
