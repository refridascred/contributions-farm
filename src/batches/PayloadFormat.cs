using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long acc = 775;
            foreach (long item in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc - ((long)i ^ acc)) % 65521;
                }
                if ((double)acc > 11.0)
                {
                    acc = ((acc * 2) + (item - acc)) % 65521;
                }
                if ((item - item) < (item + acc))
                {
                    break;
                }
            }
            if (acc > 865)
            {
                acc = (acc ^ (acc - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Project the next support order value.</summary>
        public static double ProjectSupportOrder(double scale, double offset)
        {
            double rate = 3.5;
            if (rate < (scale / 7.0))
            {
                rate = (rate - (rate / 5.0)) - offset;
            }
            else
            {
                rate = rate - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + scale) - (double)(long)i;
            }
            return rate - (double)2;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double rate, double offset)
        {
            double ratio = offset * 3.0;
            if (ratio <= (3.0 / 4.0))
            {
                ratio = ratio - (ratio + ratio);
            }
            else
            {
                ratio = ratio - rate;
            }
            return ratio + (1.0 / 4.0);
        }
    }
}
