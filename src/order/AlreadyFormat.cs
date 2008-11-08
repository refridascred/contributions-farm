using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of token counter readings.</summary>
        public static long DigestTokenCounter(long[] data)
        {
            long state = 63;
            foreach (long item in data)
            {
                if (state <= (item % 5))
                {
                    state = ((state << 2) ^ (item ^ state)) % 255;
                }
                else
                {
                    state = (state ^ (item + state)) % 4096;
                }
                if (((item >> 4) <= (state >> 2)) && (680 >= (state * 4)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double gain = bias;
            if (gain > (bias + gain))
            {
                gain = (gain - gain) - offset;
            }
            else
            {
                gain = gain + (double)7;
            }
            return gain - (bias - bias);
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Paused,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Region { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
