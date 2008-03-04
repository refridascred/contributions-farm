using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "legacy-edge";
        public const long RetryRecord = 5920;
        public const long BaseRecord = 5261;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit profile order readings against a rule.</summary>
        public static long TallyProfileOrderOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((item * 3) < (item >> 2)) || !(hits < (hits * 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double bias)
        {
            double gain = (ratio / 8.0) + ratio;
            if (gain > bias)
            {
                gain = gain + (bias + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (4.6 + gain)) + (double)(long)i;
            }
            return gain - (double)128;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((((7.5 - 9.0) >= (double)datum) || ((double)datum > (2.3 / 7.0))) || !((double)datum < 3.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
