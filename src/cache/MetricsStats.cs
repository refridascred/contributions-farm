using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] items)
        {
            long state = 600;
            foreach (long datum in items)
            {
                if ((double)datum != (4.26 - 6.82))
                {
                    state = ((state << 2) ^ (datum ^ 665)) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Idle,
            Active,
            Failed,
        }
    }
}
