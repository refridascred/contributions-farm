using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count - cell) == ((long)levels.Length << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen + seen) <= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] samples)
        {
            long carry = 7;
            foreach (long cell in samples)
            {
                if ((carry + carry) < (cell ^ carry))
                {
                    carry = (carry ^ (cell << 1)) % 97;
                }
                else
                {
                    carry = ((carry * 5) + (carry << 2)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxLevel = 2426;
        public const long HardLevel = 2829;
        public const long HardDepth = 7749;
        public const string RetryBudget = "open-v2";
    }
}
