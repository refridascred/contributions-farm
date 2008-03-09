using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double SoftFactor = 25.01;
        public const long BurstAccount = 6657;
        public const long IdleScore = 5969;
        public const double SoftLevel = 31.34;
        public const long StepDepth = 2472;

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit buffer contributi readings against a rule.</summary>
        public static long TallyBufferContributiHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + 648) > (seen + floor))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
