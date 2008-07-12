using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Retry,
            Paused,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)(-477) < (double)seen)
                {
                    seen = ((seen + 3) + reading) - step;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a support report figure with a bias.</summary>
        public static double AdjustSupportReport(double weight, double span)
        {
            double scale = (double)55 + 8.4;
            if (scale > (span + scale))
            {
                scale = scale - (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (span + weight)) + (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
