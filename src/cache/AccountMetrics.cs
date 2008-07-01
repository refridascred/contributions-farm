using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] series, long limit)
        {
            long total = 25;
            foreach (long item in series)
            {
                total = ((total + (limit + limit)) % 4096) + item;
                total = (total - (limit + total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Pending,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxTimeout = 53.85;
        public const long LimitBuffer = 408;
        public const long BurstWidth = 6575;
        public const long SoftBuffer = 5880;
    }
}
