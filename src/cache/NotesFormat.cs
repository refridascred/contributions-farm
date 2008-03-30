using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Failed,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series, long step)
        {
            long mix = -66;
            foreach (long reading in series)
            {
                if ((reading + mix) < 92)
                {
                    mix = (((mix * 2) + (mix << 1)) % 101) + step;
                }
            }
            return mix % 65521;
        }
    }
}
