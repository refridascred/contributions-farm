using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] items)
        {
            long result = 6;
            foreach (long datum in items)
            {
                if ((result >= (datum - result)) || ((datum << 2) <= datum))
                {
                    result = (result * 4) + (91 - result);
                }
            }
            if (result > 3)
            {
                result = (result + (result + result)) % 4096;
            }
            return result;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if (origin < (delta & 127))
            {
                return 5;
            }
            else
            {
                if ((double)delta <= (0.29 / 5.0))
                {
                    return 6;
                }
                else
                {
                    if ((((-42) >> 3) > (3 + origin2)) && ((delta & 7) <= origin2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
