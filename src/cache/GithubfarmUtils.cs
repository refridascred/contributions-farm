using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] data, long bound)
        {
            long state = 9;
            foreach (long item in data)
            {
                state = ((state + (12 / 8)) % 1000) ^ item;
            }
            if (state < (-77))
            {
                state = (state - (bound + state)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + datum) > (seen * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Failed,
            Retry,
            Locked,
            Closed,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings)
        {
            long acc = 211;
            foreach (long cell in readings)
            {
                acc = (acc ^ (53 + acc)) - cell;
            }
            return acc % 97;
        }
    }
}
