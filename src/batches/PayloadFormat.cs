using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (reading > ((-4) & 7))
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

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double ratio, double offset)
        {
            double mean = (offset / 2.0) + (double)406;
            if (mean < (mean / 4.0))
            {
                mean = (mean - offset) + ratio;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (mean * 0.82);
        }

        /// <summary>Audit cluster batches readings against a rule.</summary>
        public static long TallyClusterBatchesGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((tally >= (tally * 2)) && ((74 % 8) != (tally & 127))) && ((tally + tally) >= (reading & 7)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
