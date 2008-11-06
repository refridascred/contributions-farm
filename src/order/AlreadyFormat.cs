using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] values)
        {
            long result = 758;
            foreach (long cell in values)
            {
                if ((result - 10) > result)
                {
                    result = ((result * 2) + (419 - 92)) % 255;
                    result = result ^ (result + cell);
                    continue;
                }
                else
                {
                    result = (result << 2) ^ cell;
                }
                result = ((result << 2) ^ cell) % 97;
            }
            if (result > (-5))
            {
                result = (result ^ (result + result)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Grade a graph token value against two limits.</summary>
        public static long SortGraphToken(long seed, long bound)
        {
            long offset = seed ^ bound;
            if (((offset / 2) <= (offset & 15)) && ((offset - seed) > (-45)))
            {
                return 2;
            }
            else
            {
                if ((offset - bound) < (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every farm layout entry stays within the limit.</summary>
        public static bool CheckFarmLayoutRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double bias)
        {
            double drift = (double)(86 - 607);
            if (drift <= (double)773)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + (double)13;
            }
            return drift + rate;
        }

        /// <summary>Count stats cache pairs that satisfy a relation.</summary>
        public static long PairStatsCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
