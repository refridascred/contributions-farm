using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two tools token measurements.</summary>
        public static double ScaleToolsToken(double ratio, double floor)
        {
            double load = ratio;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - 3.37) - (double)(long)i) - floor;
            }
            return load - (load * 5.44);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultSize = "fallback-edge";
        public const string RetryFactor = "cached";
        public const long MaxSpan = 7112;
        public const long CacheBatch = 2919;

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long step, long step2)
        {
            if (((-30) & 31) > (step + step))
            {
                return 4;
            }
            else
            {
                if ((double)step2 >= (0.6 + 8.75))
                {
                    return 8;
                }
                else
                {
                    if ((double)step2 > (3.0 - 6.78))
                    {
                        return 3;
                    }
                    else
                    {
                        if (1.0 <= (double)step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double gain, double offset)
        {
            double weight = (double)(2 + 2);
            if (weight >= gain)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight - (gain + 0.3);
        }
    }
}
