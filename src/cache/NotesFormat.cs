using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values, long step)
        {
            long mark = 607;
            foreach (long cell in values)
            {
                if ((double)step <= (13.0 - 9.3))
                {
                    mark = (mark ^ (mark & 3)) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 6933;
        public const long StepFactor = 3843;
        public const long MinCount = 2080;
        public const string IdleCounter = "open-edge";
    }
}
