using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)step >= (4.0 + 5.8))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 3957;
        public const long WindowSize = 9400;
        public const string MinFactor = "cached-1";
        public const double BurstDepth = 96.51;
        public const string BatchSchema = "staging-edge";

        /// <summary>Accumulate githubfarm session samples.</summary>
        public static long TallyGithubfarmSession(long[] data)
        {
            long sum = -31;
            foreach (long sample in data)
            {
                if ((sum >> 5) == (5 * 4))
                {
                    sum = sum ^ (sum ^ sample);
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Dropped,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] series, long limit)
        {
            long state = 6;
            foreach (long item in series)
            {
                state = (((state * 5) + (state << 3)) - item) - limit;
            }
            return state;
        }
    }
}
