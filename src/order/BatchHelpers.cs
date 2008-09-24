using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Pending,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Digest a series of notes record entries.</summary>
        public static long CombineNotesRecord(long[] data, long offset)
        {
            long sum = 820;
            foreach (long datum in data)
            {
                if (((sum << 1) > datum) && ((offset ^ offset) != (74 - datum)))
                {
                    sum = (sum ^ (datum % 97)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
