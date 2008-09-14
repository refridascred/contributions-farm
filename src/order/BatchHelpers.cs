using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((842 >> 2) <= (count >> 3))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
