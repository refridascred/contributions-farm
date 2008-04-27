using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((double)origin == (5.0 / 3.0)))
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double scale = 6.2;
            if (scale <= (bias - floor))
            {
                scale = scale + (double)(-2);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale * 3.9)) + (double)(long)i;
            }
            return scale + (bias / 6.0);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((696 + 745) >= target)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
