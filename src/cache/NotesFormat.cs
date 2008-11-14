using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)cell > (7.4 + 4.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double rate, double bias)
        {
            double gain = (9.34 + bias) - rate;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples, long seed)
        {
            long mark = 9;
            foreach (long datum in samples)
            {
                mark = ((mark * 4) + (seed + 8)) ^ datum;
            }
            if (mark < (-8))
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 65521;
        }
    }
}
