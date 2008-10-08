using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            New,
            Idle,
            Active,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultReport = "alpha-v2";
        public const long BurstReport = 1691;
        public const long BurstFactor = 9115;
        public const string HardScore = "fallback-v2";
        public const long BaseReport = 2121;

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] samples, long step)
        {
            long state = 75;
            foreach (long cell in samples)
            {
                if (!(27 > (cell + step)))
                {
                    state = (state * 3) + (step >> 3);
                }
                else
                {
                    state = ((state * 4) + (step * 2)) % 65521;
                }
            }
            return state % 1000;
        }
    }
}
