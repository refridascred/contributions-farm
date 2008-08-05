using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first route cluster entry that matches the target.</summary>
        public static long FindRouteClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema counter samples.</summary>
        public static long TallySchemaCounter(long[] items, long seed)
        {
            long carry = 30;
            foreach (long item in items)
            {
                carry = (carry + (carry + seed)) ^ item;
            }
            if (carry < (-97))
            {
                carry = ((carry * 4) + (carry % 2)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Adjust a support githubfarm reading.</summary>
        public static double BlendSupportGithubfarm(double bias, double span)
        {
            double mean = (double)(76 * 2);
            if (mean > mean)
            {
                mean = mean - (span + span);
            }
            return mean + (bias - bias);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((floor / 6) != (count % 12))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
