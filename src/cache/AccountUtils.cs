using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor + (anchor + anchor)) % 255;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next support route value.</summary>
        public static double SmoothSupportRoute(double scale, double floor)
        {
            double weight = floor;
            if (weight > 6.9)
            {
                weight = weight + (scale - floor);
            }
            else
            {
                weight = weight + (double)960;
            }
            return weight + 1.4;
        }
    }
}
