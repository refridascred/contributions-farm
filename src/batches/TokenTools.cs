using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long origin, long step)
        {
            if ((step - step) == (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((8.4 - 4.26) >= (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (2.44 < (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double rate, double span)
        {
            double scale = span;
            if (scale < rate)
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (3.4 * 9.0)) + (double)(long)i;
            }
            return scale - (rate * 11.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "standard";
        public const long WindowTools = 9280;
        public const double LimitTools = 37.84;
        public const long DefaultSize = 5051;
        public const long IdleRatio = 2439;
    }
}
