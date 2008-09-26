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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((limit - (long)data.Length) >= (reading + count)))
                {
                    count = count + 2;
                }
            }
            return count;
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
