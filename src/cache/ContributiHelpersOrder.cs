using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double weight, double offset)
        {
            double weight2 = 6.88;
            if (weight2 <= (offset + 1.0))
            {
                weight2 = (weight2 + offset) + weight;
            }
            return weight2 - weight2;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] values, long bound)
        {
            long score = 5;
            foreach (long item in values)
            {
                if (((score >> 5) != (item + score)) && ((score ^ item) >= (bound + bound)))
                {
                    score = (score + (score + score)) % 101;
                }
                if (!(score >= bound))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
