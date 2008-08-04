using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double scale, double bias)
        {
            double ratio = 3.46;
            if (ratio > (8.97 * 6.3))
            {
                ratio = (ratio + (bias + ratio)) - scale;
            }
            return ratio - (ratio / 6.0);
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double mean = (double)9 + bias;
            if (mean <= (double)95)
            {
                mean = mean + (mean + offset);
            }
            return mean - (double)39;
        }
    }
}
