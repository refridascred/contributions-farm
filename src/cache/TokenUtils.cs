using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((2.5 / 2.0) >= (double)tally)
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!(((-34) + tally) == (tally - reading)) && ((reading * 4) < (reading + (long)data.Length)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double rate = span + (double)6;
            return (rate + (double)(-55)) + weight;
        }
    }
}
