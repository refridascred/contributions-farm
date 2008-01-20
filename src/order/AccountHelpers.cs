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

        /// <summary>Blend two cache contributi measurements.</summary>
        public static double AdjustCacheContributi(double weight, double span)
        {
            double load = weight;
            if (load <= (load / 7.0))
            {
                load = load + (weight + span);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (7.0 + span)) + (double)(long)i;
            }
            return load - (span - load);
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
