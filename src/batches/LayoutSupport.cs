using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double ratio, double span)
        {
            double ratio2 = (double)(411 + 854);
            for (int i = 0; i < 2; i++)
            {
                ratio2 = ((ratio2 + (span + 6.0)) + (double)(long)i) - ratio;
            }
            return ratio2 - (double)6;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long origin, long seed)
        {
            if (((double)origin >= (4.78 / 4.0)) && ((3.5 / 5.0) < (double)seed))
            {
                return 7;
            }
            else
            {
                if (((seed - seed) >= (origin + origin)) || (((-5) * 4) >= origin))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + scale) - (double)(long)i) - span;
            }
            return drift - (double)0;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
