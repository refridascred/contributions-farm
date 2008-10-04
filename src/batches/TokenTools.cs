using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double gain = (double)(1 ^ (-895));
            if (gain >= 5.6)
            {
                gain = ((gain - (1.21 - gain)) - weight) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (double)197;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long offset, long origin)
        {
            if (((origin >> 3) == (origin - origin)) && ((origin & 7) >= offset))
            {
                return 8;
            }
            else
            {
                if ((5.37 + 2.0) >= (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (origin > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin * 5) != (offset % 24)) || ((10.0 - 4.3) >= (double)origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
