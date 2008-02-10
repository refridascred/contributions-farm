using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Stale,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 8786;
        public const long MaxBudget = 6001;
        public const string LimitScore = "legacy-1";
        public const double IdleReport = 86.14;
    }
}
