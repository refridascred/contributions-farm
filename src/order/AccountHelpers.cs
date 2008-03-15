using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate account queue samples.</summary>
        public static long WeighAccountQueue(long[] data)
        {
            long total = 764;
            foreach (long cell in data)
            {
                total = (((total << 2) ^ 474) % 101) - cell;
            }
            return total % 97;
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

        /// <summary>Count the checks profile entries that pass the check.</summary>
        public static long TallyChecksProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen % 97) != (reading & 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Synced,
            Closed,
        }
    }
}
