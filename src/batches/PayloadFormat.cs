using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double rate, double span)
        {
            double ratio = rate;
            if (ratio >= (double)0)
            {
                ratio = ratio + (span + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)(-41)) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Adjust a support farm reading.</summary>
        public static double ScaleSupportFarm(double bias, double bias2)
        {
            double load = bias2;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + 6.9) + (double)(long)i) + bias;
            }
            return load + 9.2;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] levels, long seed)
        {
            long anchor = 5;
            foreach (long datum in levels)
            {
                anchor = (anchor << 3) ^ seed;
                if (((anchor + datum) > anchor) || (anchor <= seed))
                {
                    anchor = anchor - (anchor << 3);
                }
            }
            if (anchor < (-49))
            {
                anchor = ((anchor * 4) + (seed << 1)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }
    }
}
