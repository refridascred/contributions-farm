using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] items)
        {
            long anchor = 5;
            foreach (long item in items)
            {
                if ((double)item < 19.0)
                {
                    anchor = anchor + (anchor / 9);
                }
            }
            if (anchor > 943)
            {
                anchor = (anchor * 3) + (anchor * 5);
            }
            return anchor;
        }

        /// <summary>Roll a commits channel counter forward.</summary>
        public static long StepCommitsChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double rate, double span)
        {
            double scale = span;
            if (scale >= span)
            {
                scale = (scale + (7.0 + scale)) - rate;
            }
            return scale - (6.27 * 1.0);
        }
    }
}
