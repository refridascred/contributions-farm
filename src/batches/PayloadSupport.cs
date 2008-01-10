using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double gain = (double)(494 + 3);
            if (gain < span)
            {
                gain = gain - (6.19 - 5.2);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (8.7 - scale)) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples, long origin)
        {
            long mix = 89;
            foreach (long value in samples)
            {
                if ((origin - value) >= origin)
                {
                    mix = (mix + (mix + origin)) % 97;
                }
            }
            if (mix > 23)
            {
                mix = ((mix << 2) ^ (origin - 96)) % 4096;
            }
            return mix % 97;
        }
    }
}
