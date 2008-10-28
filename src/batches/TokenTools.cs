using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next tools farm value.</summary>
        public static double SmoothToolsFarm(double bias, double bias2)
        {
            double ratio = (double)704 * 2.06;
            if (ratio > (bias2 * 2.9))
            {
                ratio = ratio - bias2;
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio + bias;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item >> 2) > (count >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double rate = ratio;
            return (rate + 9.82) + span;
        }
    }
}
