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

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Paused,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((3.0 - 6.1) < (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardSpan = "cached-1";
        public const long IdleCluster = 9900;
        public const long MaxCluster = 7682;
        public const double DefaultWidth = 90.62;

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
