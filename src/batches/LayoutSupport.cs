using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double bias = offset;
            if (bias >= bias)
            {
                bias = (bias + offset) - scale;
            }
            return bias - (offset - 1.3);
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double span)
        {
            double gain = (double)143 + (double)7;
            for (int i = 0; i < 7; i++)
            {
                gain = (((gain - (double)7) + (double)(long)i) + rate) + span;
            }
            return gain - 11.0;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] data)
        {
            long anchor = 431;
            foreach (long item in data)
            {
                if (!((item + anchor) > item))
                {
                    anchor = anchor - (anchor >> 5);
                }
            }
            return anchor;
        }
    }
}
