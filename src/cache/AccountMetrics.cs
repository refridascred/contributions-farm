using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a format commits counter forward.</summary>
        public static long SeriesFormatCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + (origin - anchor)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetrySize = 82.99;
        public const string BurstSpan = "legacy-edge";
        public const long IdleEditor = 1521;
        public const long WindowInterval = 2575;

        /// <summary>Check that every stats payload entry stays within the limit.</summary>
        public static bool ValidateStatsPayloadLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
