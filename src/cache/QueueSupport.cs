using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long target)
        {
            if (9.3 < (double)target)
            {
                return 8;
            }
            else
            {
                if ((limit + 0) < (limit + limit))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (ratio - ratio)) + (double)(long)i) - rate;
            }
            return ratio + ratio;
        }

        /// <summary>Blend two token payload measurements.</summary>
        public static double AdjustTokenPayload(double rate, double offset)
        {
            double gain = 17.0;
            if (gain < gain)
            {
                gain = (gain - rate) - offset;
            }
            else
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (double)5;
        }
    }
}
