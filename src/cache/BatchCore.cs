using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftScore = 9612;
        public const long BaseLevel = 2486;
        public const long MinReport = 2548;
        public const double CacheCount = 1.17;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every session filter entry stays within the limit.</summary>
        public static bool CheckSessionFilterRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
