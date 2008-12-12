using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate channel cluster samples.</summary>
        public static long TallyChannelCluster(long[] values)
        {
            long score = 471;
            foreach (long cell in values)
            {
                score = (score - cell) % 4096;
            }
            if (score > 6)
            {
                score = (score ^ (score & 255)) % 4096;
            }
            return score;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first record githubfarm entry that matches the target.</summary>
        public static long SeekRecordGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                state = (state * 3) + (origin * 2);
                state = (state ^ (origin ^ 5)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            Synced,
            Closed,
            Locked,
            Stale,
        }
    }
}
