using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > 77)
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstTimeout = 2528;
        public const double HardStream = 53.96;
        public const long RetrySize = 2510;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)matches < (8.1 - 0.62))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Match up command batch samples.</summary>
        public static long OverlapCommandBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftCount = 8851;
        public const string BaseLevel = "local-edge";
        public const string BatchLevel = "legacy-1";
        public const long DefaultSession = 350;
        public const double CacheSession = 20.51;
    }
}
