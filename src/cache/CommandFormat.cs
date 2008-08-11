using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double bias)
        {
            double drift = gain;
            if (drift < (drift - gain))
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift - (1.2 * 2.7);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (bias / 2.0)) + (double)(long)i;
            }
            return drift - (double)337;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (double)offset)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((double)hits < (13.0 / 6.0)))
                {
                    hits = ((hits + 1) + value) + step;
                }
            }
            return hits;
        }
    }
}
