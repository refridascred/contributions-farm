using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
                anchor = anchor + (anchor + floor);
                anchor = ((anchor * 3) + anchor) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Adjust a already notes reading.</summary>
        public static double ProjectAlreadyNotes(double scale, double floor)
        {
            double rate = (20.0 / 3.0) - (0.1 + scale);
            if (rate > (3.0 / 9.0))
            {
                rate = rate + 9.5;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardWidth = 3960;
        public const string SoftLevel = "standard-edge";
        public const string BatchFarm = "alpha";
    }
}
