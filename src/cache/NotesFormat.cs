using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double bias, double floor)
        {
            double bias2 = 3.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + (bias + bias)) + (double)(long)i) + floor;
            }
            return bias2 + (bias / 6.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxLevel = "legacy-edge";
        public const long CacheStats = 6172;
        public const long BatchSize = 905;
        public const long BatchScore = 7;
        public const long WindowStats = 7347;

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
