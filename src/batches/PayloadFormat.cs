using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double rate = 18.0;
            if (rate < weight)
            {
                rate = rate + span;
            }
            return rate - span;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long floor)
        {
            long carry = 684;
            foreach (long cell in items)
            {
                carry = ((carry * 2) + cell) - floor;
            }
            if (carry > 19)
            {
                carry = carry + (440 - (-818));
            }
            return carry % 4096;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
