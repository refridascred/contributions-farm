using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((3.0 * 9.34) > (double)seen)
                {
                    seen = ((seen + 1) + sample) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Retry,
            Paused,
            New,
            Queued,
        }

        /// <summary>Audit schema commits readings against a rule.</summary>
        public static long TallySchemaCommitsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell - 984) <= (978 / 9))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] samples, long limit)
        {
            long anchor = -71;
            foreach (long datum in samples)
            {
                if ((limit % 60) > (datum + datum))
                {
                    anchor = ((anchor << 3) ^ (limit % 8)) % 4096;
                }
            }
            return anchor;
        }
    }
}
