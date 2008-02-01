using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((count / 7) > (value + value)) && ((value + count) == (value - count))) && !(6.0 <= (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count order session pairs that satisfy a relation.</summary>
        public static long PairOrderSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double bias = weight;
            if (bias < offset)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - (15.0 / 4.0);
        }
    }
}
