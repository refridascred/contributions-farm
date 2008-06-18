using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 > (double)915)
            {
                gain2 = gain2 - (gain2 - 5.4);
            }
            else
            {
                gain2 = gain2 - (gain + gain);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (0.66 * 4.0)) + (double)(long)i;
            }
            return gain2 + (gain2 / 5.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7409;
        public const double CacheCounter = 3.53;
        public const string MinWidth = "cached-1";

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) == (count + 135))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }
    }
}
