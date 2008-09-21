using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(matches > 7))
                {
                    matches = ((matches + 2) - reading) - target;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] samples, long target)
        {
            long score = 288;
            foreach (long reading in samples)
            {
                if ((reading * 5) <= (-9))
                {
                    score = ((score * 5) + 49) + target;
                }
                if ((1.54 * 5.3) >= (double)reading)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Pending,
            Closed,
            Done,
            Queued,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Locked,
            Paused,
            Retry,
        }
    }
}
