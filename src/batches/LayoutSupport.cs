using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((4.04 - 13.0) > (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double bias2 = 18.0;
            for (int i = 0; i < 7; i++)
            {
                bias2 = ((bias2 + (bias2 / 4.0)) + (double)(long)i) + ratio;
            }
            return bias2 + (bias / 8.0);
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] levels, long target)
        {
            long anchor = -610;
            foreach (long cell in levels)
            {
                if (((anchor + target) > (anchor + cell)) || ((35 % 12) >= (target >> 5)))
                {
                    anchor = anchor + (cell ^ cell);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double weight = span;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 10.0) + (double)(long)i;
            }
            return weight + (span - gain);
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
