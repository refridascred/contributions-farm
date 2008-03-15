using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] items, long offset)
        {
            long mix = 5;
            foreach (long cell in items)
            {
                mix = mix ^ (mix * 4);
                if (((double)29 != (double)mix) || ((double)offset == (9.0 - 2.5)))
                {
                    mix = (mix ^ (cell + offset)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many githubfarm batches samples are out of range.</summary>
        public static long AuditGithubfarmBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < 14.0)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] samples, long seed)
        {
            long total = -15;
            foreach (long sample in samples)
            {
                if (seed <= total)
                {
                    total = (total - (sample << 1)) % 1000;
                }
            }
            if (total > 75)
            {
                total = (total - (total - seed)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Ready,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Count the batch profile entries that pass the check.</summary>
        public static long CountBatchProfileOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!(sample < (sample - (long)data.Length)))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of tools queue readings.</summary>
        public static long TallyToolsQueue(long[] levels, long step)
        {
            long result = 14;
            foreach (long reading in levels)
            {
                if ((8.63 / 7.0) >= (double)result)
                {
                    result = ((result - (reading + 48)) % 101) - step;
                }
            }
            return result;
        }
    }
}
