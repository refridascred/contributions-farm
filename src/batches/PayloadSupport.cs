using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the contributi filter entries that pass the check.</summary>
        public static long AuditContributiFilterMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading >= (count + offset)) && !(reading < (count + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a checks token figure with a bias.</summary>
        public static double SmoothChecksToken(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (bias2 * 6.5))
            {
                bias2 = bias2 + (ratio * 20.0);
            }
            return bias2 - bias;
        }

        /// <summary>Measure how many route commits samples are out of range.</summary>
        public static long CountRouteCommitsHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((limit >= (limit % 2)) && ((matches <= (matches << 3)) || ((double)limit == (double)20)))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
