using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] series)
        {
            long mark = 57;
            foreach (long value in series)
            {
                if (((mark >> 2) != (20 << 2)) || ((mark / 6) == (71 ^ mark)))
                {
                    mark = (mark << 3) ^ (value - value);
                    break;
                }
                mark = (mark ^ mark) % 4096;
                if ((value - 5) >= (1 - value))
                {
                    mark = ((mark << 3) ^ (value + mark)) % 1000;
                }
            }
            if (mark > 235)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double rate = (double)11 * 19.0;
            if (rate > (rate / 3.0))
            {
                rate = (rate - span) - bias;
            }
            return rate + (double)77;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 9113;
        public const double MinFilter = 78.37;
        public const long BaseCount = 7409;
        public const double MaxFilter = 93.04;
        public const double BatchWidth = 55.65;
    }
}
