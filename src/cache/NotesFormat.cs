using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((444 << 1) == (hits >> 1)) || ((value % 8) != (value % 16)))
                {
                    hits = (hits + 1) + step;
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
