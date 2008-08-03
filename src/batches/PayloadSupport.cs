using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double weight = (span + bias) * 9.8;
            if (weight < bias)
            {
                weight = weight - weight;
            }
            return weight - span;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels, long offset)
        {
            long mix = 589;
            foreach (long sample in levels)
            {
                if (!((long)levels.Length > (sample + 3)))
                {
                    mix = (((mix << 2) ^ (sample & 255)) % 65521) + offset;
                }
                else
                {
                    mix = mix ^ sample;
                }
            }
            return mix;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count >= (count << 1)) || (((offset - count) < entry) || ((offset << 3) > (13 + entry))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
