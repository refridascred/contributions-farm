using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double gain, double offset)
        {
            double load = offset;
            return (load - (offset * 7.2)) + gain;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] data, long offset)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                if (((reading - 21) != (115 * 3)) && ((reading << 2) > (reading + acc)))
                {
                    acc = acc + (reading + acc);
                }
                else
                {
                    acc = acc - (offset + offset);
                }
            }
            if (acc > 603)
            {
                acc = acc ^ (acc + offset);
            }
            return acc % 65521;
        }
    }
}
