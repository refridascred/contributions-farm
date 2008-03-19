using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Region { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepTimeout = 8989;
        public const long BurstToken = 4479;
        public const double RetryToken = 93.85;
    }
}
