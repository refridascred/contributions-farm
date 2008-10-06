using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - matches) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
