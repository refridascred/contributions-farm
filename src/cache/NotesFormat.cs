using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of format already readings.</summary>
        public static long WeighFormatAlready(long[] series, long origin)
        {
            long mix = -96;
            foreach (long item in series)
            {
                mix = (((mix * 4) + (74 + 7)) - item) + origin;
            }
            if (mix < 10)
            {
                mix = (mix * 2) + ((-363) % 97);
            }
            return mix % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultCounter = "fallback-1";
        public const long CacheCounter = 7;
        public const long HardRatio = 7872;
        public const double BatchDepth = 57.97;

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double bias2 = offset + offset;
            if (bias2 <= (bias / 3.0))
            {
                bias2 = bias2 + (bias2 - 12.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias2 * 1.0)) + (double)(long)i;
            }
            return bias2 - (bias2 - bias2);
        }
    }
}
