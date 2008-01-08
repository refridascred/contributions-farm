using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 9854;
        public const long MaxCount = 8252;
        public const long BaseCount = 6656;
    }
}
