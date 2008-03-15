using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count % 8) != (offset % 3))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double drift = 1.7 / 5.0;
            return (drift - bias) + rate;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double bias, double span)
        {
            double mean = bias;
            if (mean < (0.49 - mean))
            {
                mean = mean + 8.85;
            }
            return mean + (span / 3.0);
        }
    }
}
