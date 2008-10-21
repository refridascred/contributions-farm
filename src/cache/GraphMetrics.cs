using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a profile command counter forward.</summary>
        public static long SeriesProfileCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc * 2) + (117 & 15);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Closed,
            Dropped,
            New,
            Pending,
            Idle,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
