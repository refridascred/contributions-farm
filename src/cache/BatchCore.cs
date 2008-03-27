using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Locked,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit buffer context readings against a rule.</summary>
        public static long TallyBufferContextHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen - datum) > (datum & 127))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Synced,
            Paused,
            Failed,
            Retry,
        }
    }
}
