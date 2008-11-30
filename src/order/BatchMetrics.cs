using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchWidth = "local-v2";
        public const double CacheFactor = 6.18;
        public const long LimitMetrics = 4214;
        public const double DefaultMetrics = 94.8;
        public const long CacheMetrics = 7912;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry - entry) < bound)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] readings)
        {
            long anchor = 390;
            foreach (long value in readings)
            {
                anchor = ((anchor + ((long)readings.Length * 3)) % 97) - value;
            }
            if (anchor < 330)
            {
                anchor = (anchor - (anchor + 5)) % 255;
            }
            return anchor;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
