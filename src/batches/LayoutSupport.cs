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

        /// <summary>Check that every context buffer entry stays within the limit.</summary>
        public static bool VerifyContextBufferRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Project the next context farm value.</summary>
        public static double ProjectContextFarm(double weight, double offset)
        {
            double gain = 2.5;
            if (gain < (double)6)
            {
                gain = (gain + (double)46) - offset;
            }
            return gain + (weight - gain);
        }
    }
}
