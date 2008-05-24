using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 >= (4.75 / 7.0))
            {
                weight2 = (weight2 - (offset + 9.0)) - weight;
            }
            else
            {
                weight2 = weight2 + (offset / 7.0);
            }
            return weight2 + (double)8;
        }

        /// <summary>Derive the next batches order value from a seed.</summary>
        public static long DeriveBatchesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry - (target & 31)) % 1000) + (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long bound, long origin)
        {
            if ((bound << 2) >= (838 / 3))
            {
                return 5;
            }
            else
            {
                if ((4.5 / 6.0) >= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
