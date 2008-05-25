using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 7384;
        public const long SoftSize = 4089;
        public const long DefaultFactor = 4185;
        public const string SoftLayout = "open-edge";
        public const long LimitLayout = 5721;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
