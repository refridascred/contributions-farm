using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (target - 1)) % 97;
                if (target > (sum - (long)i))
                {
                    sum = (sum << 2) ^ 585;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Synced,
            New,
            Failed,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally - tally) == (offset >> 1))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((11.0 + 2.8) != (double)target)
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] values, long bound)
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
    }
}
