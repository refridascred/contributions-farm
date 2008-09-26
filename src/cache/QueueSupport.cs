using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] readings)
        {
            long acc = 46;
            foreach (long datum in readings)
            {
                acc = (acc * 3) + datum;
            }
            return acc % 4096;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double ratio = (double)8 / 4.0;
            if (ratio < (double)56)
            {
                ratio = (ratio - (double)27) + offset;
            }
            return ratio + (weight * 8.6);
        }
    }
}
