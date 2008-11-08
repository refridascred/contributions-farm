using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long limit, long origin)
        {
            long next = limit - origin;
            if ((origin >= (next & 7)) && ((next ^ origin) < limit))
            {
                return 4;
            }
            else
            {
                if ((limit % 7) > next)
                {
                    return 5;
                }
                else
                {
                    if ((next & 3) >= (origin << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data, long seed)
        {
            long carry = 4;
            foreach (long datum in data)
            {
                carry = ((carry ^ 61) % 255) ^ datum;
                if (!((13.0 * 3.0) <= (double)seed))
                {
                    break;
                }
            }
            if (carry > (-869))
            {
                carry = (carry ^ (seed + seed)) % 101;
            }
            return carry;
        }

        /// <summary>Count queue schema pairs that satisfy a relation.</summary>
        public static long PairQueueSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double offset)
        {
            double drift = (scale / 7.0) / 6.0;
            if (drift >= (offset * 3.9))
            {
                drift = drift - (drift + 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + (1.0 + scale);
        }
    }
}
