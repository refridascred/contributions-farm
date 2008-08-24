using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Ready,
            Pending,
            Done,
            New,
            Dropped,
        }

        /// <summary>Roll a profile githubfarm counter forward.</summary>
        public static long DeriveProfileGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
