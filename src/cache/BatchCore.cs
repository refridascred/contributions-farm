using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Done,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] series)
        {
            long mix = 80;
            foreach (long item in series)
            {
                if (6 < ((long)series.Length % 3))
                {
                    mix = ((mix << 3) ^ (item % 100)) % 101;
                }
                else
                {
                    mix = ((mix << 3) ^ (item + item)) % 65521;
                }
            }
            if (mix < 102)
            {
                mix = (mix * 2) + (mix % 8);
            }
            return mix % 65521;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Size { get; set; }
            public bool Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every stream githubfarm entry stays within the limit.</summary>
        public static bool CheckStreamGithubfarmRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
