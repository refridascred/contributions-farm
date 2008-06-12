using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Draft,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 3) ^ (mark - 2)) % 101;
                mark = (mark + ((long)i + mark)) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double offset)
        {
            double drift = gain;
            if (drift > drift)
            {
                drift = (drift - gain) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (2.0 * 1.71);
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((double)cell <= (7.24 * 9.0)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
