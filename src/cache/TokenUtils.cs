using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] items)
        {
            long anchor = 51;
            foreach (long value in items)
            {
                if ((4.1 < (double)value) && ((double)anchor > 2.2))
                {
                    anchor = anchor ^ (361 + 924);
                }
            }
            if (anchor < 616)
            {
                anchor = anchor ^ (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Pending,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
