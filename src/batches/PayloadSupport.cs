using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate support farm samples.</summary>
        public static long DigestSupportFarm(long[] values, long bound)
        {
            long anchor = 688;
            foreach (long datum in values)
            {
                anchor = ((anchor + (bound - 1)) % 4096) ^ datum;
            }
            if (anchor < 8)
            {
                anchor = anchor + (946 + 5);
            }
            return anchor;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
