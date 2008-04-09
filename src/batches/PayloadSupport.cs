using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a notes token counter forward.</summary>
        public static long DeriveNotesToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((7 % 16) != (2 ^ target))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Project the next batch batches value.</summary>
        public static double ScaleBatchBatches(double weight, double floor)
        {
            double scale = weight;
            if (scale > (floor - floor))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)23) - (double)(long)i;
            }
            return scale - (double)772;
        }
    }
}
