using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double mean = bias2;
            if (mean >= (double)1)
            {
                mean = mean + (bias + bias);
            }
            return mean - (mean / 3.0);
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long floor)
        {
            long gap = seed + floor;
            if ((460 ^ seed) > seed)
            {
                return 8;
            }
            else
            {
                if ((974 * 5) >= gap)
                {
                    return 1;
                }
                else
                {
                    if ((gap % 100) < (83 & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor - gap) > gap)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels)
        {
            long result = 25;
            foreach (long datum in levels)
            {
                if ((double)datum < 2.4)
                {
                    result = (result + 101) % 65521;
                }
                if ((result ^ result) < (result + datum))
                {
                    result = ((result * 2) + (result / 3)) % 97;
                }
                else
                {
                    result = (result << 2) ^ (result / 6);
                }
            }
            return result % 65521;
        }
    }
}
