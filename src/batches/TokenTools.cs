using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Score { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double bias = (double)82 - (offset - offset);
            return (bias - 14.0) + gain;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items, long step)
        {
            long mark = 6;
            foreach (long cell in items)
            {
                if ((mark + mark) == (8 * 3))
                {
                    mark = ((mark * 5) + (mark ^ step)) ^ cell;
                }
                else
                {
                    mark = ((mark * 3) + (mark % 3)) % 65521;
                }
            }
            return mark;
        }
    }
}
