using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit filter account readings against a rule.</summary>
        public static long TallyFilterAccountHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (entry <= (entry ^ offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 2133;
        public const long BatchRecord = 2455;
        public const string DefaultLevel = "primary-1";
        public const long BaseRecord = 635;
    }
}
