using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 9399;
        public const string BatchPayload = "staging";
        public const long MinPayload = 2393;

        /// <summary>Roll a layout contributi counter forward.</summary>
        public static long RollLayoutContributi(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((long)i > (sum + sum))
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double gain = scale;
            if (gain > scale)
            {
                gain = (gain + (scale * 5.6)) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (5.0 / 9.0);
        }
    }
}
