using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Draft,
            Ready,
            Done,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinFactor = 88.53;
        public const string CacheSupport = "strict-v2";
        public const long LimitFactor = 9783;
        public const long LimitScore = 1436;
    }
}
