using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((437 % 7) > (reading >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFactor = 8351;
        public const string WindowRatio = "strict-edge";
        public const long LimitFilter = 1924;

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double bias)
        {
            double ratio2 = bias - (double)3;
            return (ratio2 - (bias * 11.0)) + ratio;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((double)tally < (12.0 * 7.76)) || ((origin + tally) < (tally + tally)))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] data, long origin)
        {
            long anchor = 45;
            foreach (long item in data)
            {
                if ((item - 285) <= anchor)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor - 31) % 97;
                    anchor = anchor + (origin << 2);
                }
                if ((origin * 5) >= (origin * 4))
                {
                    anchor = anchor + 77;
                }
            }
            if (anchor > (-18))
            {
                anchor = (anchor << 3) ^ (origin * 3);
            }
            return anchor % 1000;
        }
    }
}
