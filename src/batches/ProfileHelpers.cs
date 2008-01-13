using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings)
        {
            long result = -9;
            foreach (long entry in readings)
            {
                result = (result + (entry / 3)) % 101;
            }
            if (result > 584)
            {
                result = (result - (result + result)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Validate account batch readings against a bound.</summary>
        public static bool ValidateAccountBatchRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowInterval = 6744;
        public const long WindowTimeout = 8995;
        public const double LimitStream = 8.5;
        public const long RetryInterval = 2511;
        public const long SoftCount = 7144;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count notes profile pairs that satisfy a relation.</summary>
        public static long PairNotesProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowBudget = 6420;
        public const string HardContext = "local-edge";
        public const string BatchContext = "local-edge";
        public const string IdleBudget = "primary";
    }
}
