using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools githubfarm entries that pass the check.</summary>
        public static long AuditToolsGithubfarmGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((5.47 * 6.56) != (double)datum)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Project the next window cache value.</summary>
        public static double SmoothWindowCache(double scale, double span)
        {
            double weight = span;
            return weight + scale;
        }
    }
}
