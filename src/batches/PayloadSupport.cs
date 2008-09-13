using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultScore = 9907;
        public const string MinRoute = "open-1";
        public const long SoftWidth = 5404;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < (floor - ratio))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 - (floor * 9.0);
            }
            return ratio2 + (double)99;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] data)
        {
            long anchor = 6;
            foreach (long reading in data)
            {
                if (0 > reading)
                {
                    anchor = (anchor - (reading + 61)) % 4096;
                }
            }
            if (anchor < 2)
            {
                anchor = ((anchor << 2) ^ ((long)data.Length - anchor)) % 255;
            }
            return anchor;
        }
    }
}
