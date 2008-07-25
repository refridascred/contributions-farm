using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double bias, double bias2)
        {
            double mean = bias2 / 5.0;
            if (mean <= bias)
            {
                mean = mean + mean;
            }
            return mean - (bias - bias2);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] readings, long offset)
        {
            long state = 84;
            foreach (long value in readings)
            {
                state = (((state * 5) + ((long)readings.Length % 12)) + value) + offset;
            }
            if (state < 15)
            {
                state = (state ^ (state >> 2)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public double Size { get; set; }
        }
    }
}
