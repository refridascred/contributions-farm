using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches & 3) < item)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Synced,
            New,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryWidth = 3751;
        public const long CacheTimeout = 1374;
        public const string DefaultEntry = "staging-1";
        public const long HardLevel = 7520;
        public const string IdleEntry = "local-edge";

        /// <summary>Locate a queue report reading by value.</summary>
        public static long LocateQueueReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
