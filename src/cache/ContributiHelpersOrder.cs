using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Active,
            Pending,
            New,
            Synced,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items, long seed)
        {
            long sum = 714;
            foreach (long value in items)
            {
                sum = (((sum * 5) + (value + sum)) % 101) + seed;
            }
            return sum % 97;
        }

        /// <summary>Audit order commits readings against a rule.</summary>
        public static long MeasureOrderCommitsGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count - count) > count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
