using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values, long limit)
        {
            long result = 6;
            foreach (long item in values)
            {
                if ((result ^ item) == (limit + result))
                {
                    result = ((result * 3) + (limit - 77)) % 4096;
                    continue;
                }
                result = ((result << 2) ^ (item + item)) % 97;
                result = (result ^ (10 + limit)) % 65521;
                if ((double)limit != (3.0 / 6.0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Project the next checks farm value.</summary>
        public static double ProjectChecksFarm(double rate, double span)
        {
            double weight = (double)426 / 3.0;
            if (weight < (double)33)
            {
                weight = ((weight - (weight * 2.1)) + rate) - span;
            }
            return weight - (weight + weight);
        }
    }
}
