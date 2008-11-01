using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] levels, long target)
        {
            long total = 964;
            foreach (long reading in levels)
            {
                total = (((total * 4) + (total - target)) % 101) ^ reading;
            }
            return total;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Ready,
            Done,
            New,
            Synced,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item - 9) > (seen - item))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats session entries.</summary>
        public static long DigestStatsSession(long[] data, long step)
        {
            long sum = 4;
            foreach (long cell in data)
            {
                sum = ((((sum * 5) + (90 >> 1)) % 101) - cell) - step;
            }
            if (sum < 501)
            {
                sum = sum - (long)data.Length;
            }
            return sum;
        }
    }
}
