using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a editor metrics counter forward.</summary>
        public static long RollEditorMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum << 3) ^ ((long)i * 4)) % 97;
                if (((long)i % 10) < 2)
                {
                    sum = (sum << 2) ^ ((long)i >> 2);
                }
                sum = ((sum << 3) ^ (offset - (long)i)) % 255;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetrySize = 7125;
        public const string IdleRecord = "latest-v2";
        public const long WindowDepth = 9711;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 < (16.0 - gain))
            {
                gain2 = gain2 + bias;
            }
            return gain2 + (bias - 5.9);
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
