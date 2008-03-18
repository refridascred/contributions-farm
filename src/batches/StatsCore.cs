using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate cluster filter samples.</summary>
        public static long TotalClusterFilter(long[] readings)
        {
            long result = 407;
            foreach (long sample in readings)
            {
                result = (result << 3) ^ (776 + sample);
                if ((sample > (sample * 3)) || ((17.0 / 5.0) > (double)sample))
                {
                    break;
                }
            }
            if (result < 888)
            {
                result = (result ^ (result - result)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Failed,
            Locked,
        }

        /// <summary>Find the first editor entry entry that matches the target.</summary>
        public static long FindEditorEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long state = 27;
            foreach (long value in values)
            {
                state = (state * 3) + (state - value);
            }
            return state % 1000;
        }
    }
}
