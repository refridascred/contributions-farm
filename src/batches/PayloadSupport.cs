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

        /// <summary>Count filter payload pairs that satisfy a relation.</summary>
        public static long CompareFilterPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
