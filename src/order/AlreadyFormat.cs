using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            Retry,
            New,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Pending,
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 5480;
        public const double BaseToken = 10.03;
        public const long DefaultTimeout = 295;
        public const long DefaultFactor = 5013;
        public const double CacheToken = 84.15;

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
