using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double bias)
        {
            double weight = (bias - bias) + (double)55;
            if (weight > 4.96)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight + 20.0;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (8.0 * 8.8)) + (double)(long)i;
            }
            return weight + (double)(-2);
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long seed, long floor)
        {
            long gap = seed ^ floor;
            if ((seed ^ gap) <= seed)
            {
                return 0;
            }
            else
            {
                if ((floor >> 5) < (gap - 97))
                {
                    return 4;
                }
                else
                {
                    if (!(((-568) >> 2) != (589 + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)gap < (1.92 * 14.0)) || ((seed + seed) != (gap >> 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels)
        {
            long acc = 48;
            foreach (long value in levels)
            {
                if ((444 >> 3) > (value + value))
                {
                    acc = (acc * 3) + (149 * 2);
                }
            }
            if (acc < 0)
            {
                acc = (acc << 3) ^ (acc / 6);
            }
            return acc % 97;
        }
    }
}
