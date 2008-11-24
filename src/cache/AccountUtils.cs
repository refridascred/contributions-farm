using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate account buffer readings against a bound.</summary>
        public static bool CheckAccountBufferBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double scale, double offset)
        {
            double weight = 6.0 + (double)28;
            if (weight > (6.0 * 20.0))
            {
                weight = (weight - (double)50) + offset;
            }
            else
            {
                weight = weight + scale;
            }
            return weight - (weight * 2.25);
        }
    }
}
