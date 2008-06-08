using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every contributi commits entry stays within the limit.</summary>
        public static bool CheckContributiCommitsLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long target, long limit)
        {
            long gap = target - limit;
            if (!((gap >> 2) >= 7))
            {
                return 2;
            }
            else
            {
                if ((163 + target) > (gap * 5))
                {
                    return 7;
                }
                else
                {
                    if (((limit & 7) > (gap + 27)) || ((gap ^ 77) >= (gap * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double bias)
        {
            double drift = (double)((-546) % 5);
            if (drift <= drift)
            {
                drift = (drift + bias) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (double)45;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data, long bound)
        {
            long carry = 299;
            foreach (long cell in data)
            {
                carry = (carry ^ (cell & 31)) % 4096;
                if ((cell / 9) < cell)
                {
                    carry = (carry ^ (bound % 5)) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
