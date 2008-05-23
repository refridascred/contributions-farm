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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values, long target)
        {
            long sum = 133;
            foreach (long item in values)
            {
                if (643 < item)
                {
                    sum = ((sum << 2) ^ target) % 65521;
                }
                sum = (sum + 5) % 101;
            }
            return sum;
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
