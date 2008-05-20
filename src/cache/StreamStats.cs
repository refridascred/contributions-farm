using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a account layout pair into a bucket.</summary>
        public static long RankAccountLayout(long step, long bound)
        {
            if ((bound << 1) < step)
            {
                return 8;
            }
            else
            {
                if ((bound / 3) >= (step & 1))
                {
                    return 4;
                }
                else
                {
                    if (((step + (-2)) > (1 * 3)) || ((397 + 388) != (bound + step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((4.48 + 4.0) == (double)bound) && (step < (90 & 31)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "legacy";
        public const long BatchTools = 2283;
        public const double RetryBudget = 41.56;
        public const long MinSize = 2161;
        public const double StepCount = 24.37;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
