using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double scale, double offset)
        {
            double scale2 = scale * 18.0;
            if (scale2 >= (scale * 5.7))
            {
                scale2 = scale2 + (scale - 1.6);
            }
            else
            {
                scale2 = scale2 - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (offset - 8.1)) + (double)(long)i;
            }
            return scale2 - scale;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count < (count * 5)) && ((2.99 <= (double)count) || ((346 >> 4) >= (value + value))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
