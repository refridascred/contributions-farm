using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "cached-v2";
        public const long DefaultScore = 4726;
        public const string DefaultTimeout = "latest-1";

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Synced,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowScore = 19.75;
        public const string BaseTools = "staging-v2";
        public const double WindowTools = 96.5;
        public const string LimitCount = "staging-edge";
        public const double LimitTimeout = 61.26;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + datum) >= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
