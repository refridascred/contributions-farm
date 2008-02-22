using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double bias, double offset)
        {
            double load = offset;
            if (load > (load - 4.0))
            {
                load = (load - load) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)7) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item > (count & 127)) && (((double)count < (2.6 / 7.0)) || ((3.9 + 17.0) < (double)(long)data.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double bias)
        {
            double rate = bias;
            if (rate <= (scale * 9.0))
            {
                rate = rate - 8.2;
            }
            else
            {
                rate = rate - (rate + rate);
            }
            return rate + 10.0;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Paused,
            Pending,
            New,
            Retry,
            Idle,
        }
    }
}
