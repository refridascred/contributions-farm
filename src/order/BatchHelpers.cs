using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double bias, double bias2)
        {
            double weight = (double)(34 / 7);
            if (weight > weight)
            {
                weight = (weight - weight) + bias;
            }
            else
            {
                weight = weight - bias2;
            }
            return weight - (bias2 + bias2);
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((951 + tally) != (tally << 1))
                {
                    tally = ((tally + 1) + reading) + offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Idle,
            Stale,
        }
    }
}
