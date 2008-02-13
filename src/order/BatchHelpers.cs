using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((sum >> 5) <= bound))
                {
                    sum = sum + (2 + 68);
                }
                sum = (sum - (sum * 4)) % 255;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(reading < (count - reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
