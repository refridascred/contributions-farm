using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double bias = (scale + offset) + offset;
            if (bias >= (double)9)
            {
                bias = bias - 13.0;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (bias - offset)) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double bias = span;
            if (bias > span)
            {
                bias = bias - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - (0.1 - bias);
        }
    }
}
