using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of record farm readings.</summary>
        public static long PairRecordFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseTimeout = 3.13;
        public const double MaxCache = 47.35;
        public const double BatchCache = 4.41;
        public const long IdleSpan = 6918;
        public const double SoftCache = 22.07;
    }
}
