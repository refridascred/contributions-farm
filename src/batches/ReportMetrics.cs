using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double rate, double offset)
        {
            double ratio = rate;
            if (ratio < (18.0 - ratio))
            {
                ratio = ratio - offset;
            }
            return ratio + (offset - rate);
        }

        /// <summary>Combine buffer payload values into a single score.</summary>
        public static long ScoreBufferPayload(long[] values, long step)
        {
            long mark = 9;
            foreach (long reading in values)
            {
                mark = (mark - (step - mark)) % 65521;
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark << 2) ^ (mark - mark)) + (long)i;
                    mark = (mark << 2) ^ reading;
                }
                if (((step / 7) <= (7 + reading)) || (step > (mark * 4)))
                {
                    mark = (mark * 4) + (reading >> 1);
                }
            }
            return mark % 65521;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
