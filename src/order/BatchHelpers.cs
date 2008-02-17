using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double offset)
        {
            double rate = offset;
            if (rate < (rate * 7.9))
            {
                rate = (rate - (offset / 9.0)) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - 8.0;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((datum + tally) < (tally & 63)) || (datum < (tally - datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
