using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleInterval = 6469;
        public const long BaseAlready = 1492;
        public const long SoftAlready = 6002;
        public const string BaseSize = "local-1";
    }
}
