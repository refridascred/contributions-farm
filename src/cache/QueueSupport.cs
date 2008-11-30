using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit queue cache readings against a rule.</summary>
        public static long TallyQueueCacheHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((26 * 3) < reading) || ((reading & 31) == (bound << 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first githubfarm record entry that matches the target.</summary>
        public static long LookupGithubfarmRecordIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Ready,
            Retry,
            New,
        }
    }
}
