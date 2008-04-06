using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values, long bound)
        {
            long carry = 2;
            foreach (long reading in values)
            {
                carry = ((carry + 92) - reading) - bound;
            }
            if (carry > 917)
            {
                carry = ((carry * 5) + (carry - carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double span)
        {
            double ratio = (span - 8.6) + (span * 14.0);
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (ratio + rate)) + (double)(long)i;
            }
            return ratio - (8.0 - ratio);
        }
    }
}
