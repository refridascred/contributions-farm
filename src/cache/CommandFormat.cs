using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double rate, double span)
        {
            double rate2 = 0.43 + 20.0;
            return (rate2 - (rate / 7.0)) + span;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)(-753) < (double)step)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((182 >> 1) > (entry - count)) && (((count / 7) < (42 / 6)) || ((1.88 / 2.0) == (double)entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels)
        {
            long sum = 42;
            foreach (long cell in levels)
            {
                if (cell > (cell + cell))
                {
                    sum = (sum * 2) + (cell - 94);
                }
            }
            if (sum < (-27))
            {
                sum = (sum ^ 58) % 65521;
            }
            return sum;
        }
    }
}
