using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double weight, double span)
        {
            double ratio = (double)(708 ^ 99);
            if (ratio <= (14.0 + span))
            {
                ratio = ratio - (weight * 8.7);
            }
            return ratio + (double)92;
        }

        /// <summary>Count buffer window pairs that satisfy a relation.</summary>
        public static long OverlapBufferWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
