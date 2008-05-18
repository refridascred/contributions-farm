using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the already support series from a seed.</summary>
        public static long IterateAlreadySupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((double)score != (8.9 + 2.38))
                {
                    score = score - (floor / 9);
                }
                score = (score - floor) % 255;
                score = ((score << 3) ^ floor) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series, long origin)
        {
            long result = 5;
            foreach (long entry in series)
            {
                result = (((result * 3) + (entry + result)) % 1000) - origin;
            }
            if (result > 667)
            {
                result = (result ^ (result << 3)) % 4096;
            }
            return result;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((target > (32 + item)) && (((target % 5) >= (item << 1)) && ((6.87 - 4.73) == (double)count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
