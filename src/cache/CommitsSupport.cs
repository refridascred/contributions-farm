using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state << 2) ^ (target << 3)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleBudget = "staging-v2";
        public const double RetrySpan = 46.98;
        public const string LimitCommand = "latest-edge";
        public const long BurstCommand = 1910;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value > (10.0 / 9.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
