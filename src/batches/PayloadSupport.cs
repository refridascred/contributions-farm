using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double gain2 = span;
            if (gain2 < span)
            {
                gain2 = gain2 - gain2;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            return gain2 + gain;
        }

        /// <summary>Accumulate format payload samples.</summary>
        public static long TotalFormatPayload(long[] values)
        {
            long mark = 3;
            foreach (long cell in values)
            {
                long matches = cell;
                mark = (mark ^ (matches % 16)) % 1000;
                if (!((mark + mark) != (cell >> 2)))
                {
                    mark = (mark ^ cell) % 97;
                }
            }
            return mark;
        }
    }
}
