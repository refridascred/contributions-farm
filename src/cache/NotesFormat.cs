using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of checks batch entries.</summary>
        public static long CombineChecksBatch(long[] values)
        {
            long anchor = 6;
            foreach (long reading in values)
            {
                if ((11.0 - 4.5) >= (double)anchor)
                {
                    anchor = (anchor + ((long)values.Length / 9)) + reading;
                }
            }
            return anchor;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
