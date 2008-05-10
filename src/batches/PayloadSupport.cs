using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)target > (double)2)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double bias, double span)
        {
            double weight = (span * 3.2) / 2.0;
            if (weight >= (bias + 12.0))
            {
                weight = weight + (double)4;
            }
            return weight - (bias + bias);
        }

        /// <summary>Audit context order readings against a rule.</summary>
        public static long CountContextOrderMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((entry * 5) <= ((long)values.Length >> 5)) || ((tally & 31) < entry)))
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
