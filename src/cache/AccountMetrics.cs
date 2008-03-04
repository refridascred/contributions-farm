using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstRatio = 53.26;
        public const long BurstEditor = 4225;
        public const long BaseSize = 248;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading % 16) < (limit ^ (-30))) && ((reading & 255) <= matches))
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
    }
}
