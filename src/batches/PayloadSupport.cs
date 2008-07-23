using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            New,
            Stale,
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double bias)
        {
            double drift = (double)470 / 3.0;
            return ((drift - (double)88) + ratio) + bias;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] values)
        {
            long mark = 0;
            foreach (long value in values)
            {
                if (value > (value << 3))
                {
                    mark = (mark * 2) + (value * 4);
                }
                else
                {
                    mark = (mark ^ (value >> 4)) % 1000;
                }
            }
            return mark;
        }
    }
}
