using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long seed)
        {
            long delta = offset ^ seed;
            if ((seed - seed) >= (offset << 2))
            {
                return 4;
            }
            else
            {
                if (9.0 > (double)delta)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit channel order readings against a rule.</summary>
        public static long TallyChannelOrderMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches >= (5 + 945))
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double ratio, double span)
        {
            double gain = (double)(999 << 2);
            if (gain > 4.2)
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - (ratio / 6.0);
        }
    }
}
