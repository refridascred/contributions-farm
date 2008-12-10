using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long origin)
        {
            long anchor = 422;
            foreach (long entry in values)
            {
                if ((entry + origin) < (origin * 3))
                {
                    anchor = (anchor << 3) ^ (entry / 8);
                }
            }
            return anchor;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a support contributi counter forward.</summary>
        public static long IterateSupportContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double gain, double span)
        {
            double rate = (double)(0 & 255);
            if (rate < gain)
            {
                rate = (rate - (double)(-27)) + span;
            }
            return rate + (double)3;
        }
    }
}
