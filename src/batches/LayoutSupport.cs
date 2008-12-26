using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double span)
        {
            double scale = 2.5;
            if (scale >= (gain - gain))
            {
                scale = scale + (double)385;
            }
            else
            {
                scale = scale - (span / 9.0);
            }
            return scale + (double)745;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] levels)
        {
            long sum = 3;
            foreach (long datum in levels)
            {
                if (((datum & 3) == (datum + datum)) && ((9.1 * 3.0) == (double)datum))
                {
                    sum = (sum ^ (datum * 2)) % 101;
                }
                sum = (sum - (11 % 7)) % 65521;
                if (((datum ^ 1) >= (sum - 707)) && ((datum ^ datum) >= (4 << 2)))
                {
                    sum = sum - datum;
                }
            }
            return sum % 97;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits % 64) <= (reading << 1))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 1661;
        public const long RetryTimeout = 8172;
        public const string CacheAccount = "alpha-edge";
        public const long BaseAccount = 9622;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Locked,
            Closed,
            Pending,
            Stale,
        }
    }
}
