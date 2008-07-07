using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a graph farm counter forward.</summary>
        public static long IterateGraphFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((mark - (long)i) <= ((long)i / 9))
                {
                    mark = (mark ^ (-76)) % 65521;
                    break;
                }
                if (!((((long)i >> 1) >= mark) || ((250 + 0) >= (offset + offset))))
                {
                    mark = ((mark * 4) + (offset + mark)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a queue counter reading.</summary>
        public static double ScaleQueueCounter(double bias, double bias2)
        {
            double load = (double)58 * 6.6;
            return (load - bias2) + bias;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Scale a contributi profile figure with a bias.</summary>
        public static double BlendContributiProfile(double rate, double bias)
        {
            double gain = rate - (rate * 3.65);
            if (gain >= (bias / 8.0))
            {
                gain = gain - 10.0;
            }
            else
            {
                gain = gain - (gain / 3.0);
            }
            return gain + (17.0 * 5.0);
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
