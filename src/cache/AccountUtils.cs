using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 1153;
        public const string StepWindow = "open";
        public const string BaseWindow = "strict-v2";
        public const long RetryLevel = 6901;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
