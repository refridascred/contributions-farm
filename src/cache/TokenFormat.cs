using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinScore = "latest-1";
        public const string LimitSupport = "staging-edge";
        public const double RetryBudget = 62.07;
        public const double DefaultCount = 90.92;
        public const long IdleFactor = 5710;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long origin, long target)
        {
            long bound = origin + target;
            if ((6.9 / 5.0) > (double)bound)
            {
                return 6;
            }
            else
            {
                if (((4.0 - 11.0) != (double)bound) && ((2.32 / 5.0) <= (double)bound))
                {
                    return 5;
                }
                else
                {
                    if ((target & 15) > (bound << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((9.3 - 6.7) > (double)entry)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }
    }
}
