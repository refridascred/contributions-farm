using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < (0.2 / 6.0))
            {
                ratio2 = (ratio2 - (double)74) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)(-7);
            }
            return ratio2 - span;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - (carry + 1)) % 4096;
                carry = carry + ((long)i - carry);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
