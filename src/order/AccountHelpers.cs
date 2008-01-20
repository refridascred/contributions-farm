using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheFactor = 6606;
        public const long BurstScore = 4076;
        public const long BurstSpan = 9461;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Stale,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Find the first route support entry that matches the target.</summary>
        public static long LocateRouteSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Synced,
            Queued,
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 9396;
        public const long BurstFormat = 3420;
        public const long SoftDepth = 3568;
    }
}
