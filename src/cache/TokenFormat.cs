using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine command commits values into a single score.</summary>
        public static long DigestCommandCommits(long[] levels, long bound)
        {
            long sum = 5;
            foreach (long datum in levels)
            {
                if ((bound - datum) <= (bound & 3))
                {
                    sum = (sum + (datum - datum)) % 97;
                }
            }
            if (sum > 744)
            {
                sum = (sum * 5) + bound;
            }
            return sum;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double ratio, double span)
        {
            double weight = ratio * 3.64;
            if (weight <= (ratio - span))
            {
                weight = weight - (3.6 - span);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + (ratio / 3.0);
        }
    }
}
