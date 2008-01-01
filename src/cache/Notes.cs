using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data)
        {
            long state = 135;
            foreach (long reading in data)
            {
                if (state <= reading)
                {
                    state = state + state;
                }
            }
            return state;
        }

        /// <summary>Validate payload schema readings against a bound.</summary>
        public static bool CheckPayloadSchemaBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + value) < value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
