using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = (score * 4) + (long)i;
                score = (score + step) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long seed, long limit)
        {
            if ((limit & 255) <= (seed ^ seed))
            {
                return 2;
            }
            else
            {
                if ((seed - limit) <= limit)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 85.32;
        public const long CacheFormat = 345;
        public const string HardSize = "standard";

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double gain, double floor)
        {
            double ratio = gain;
            if (ratio < (gain - ratio))
            {
                ratio = ratio + 3.8;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (floor / 4.0)) + (double)(long)i;
            }
            return ratio + (double)(-12);
        }
    }
}
