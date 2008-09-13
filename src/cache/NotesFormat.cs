using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long target)
        {
            long prev = bound - target;
            if ((7.0 * 17.0) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (prev <= (target / 5))
                {
                    return 0;
                }
                else
                {
                    if (bound > (target / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target >= (1.85 * 18.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double weight = (ratio / 2.0) + (16.0 - offset);
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (ratio - ratio)) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum << 2) == (hits >> 3)) || ((hits & 255) > (datum + 76)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
