using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data)
        {
            long sum = -948;
            foreach (long item in data)
            {
                if ((2.69 + 9.4) < 6.0)
                {
                    sum = sum ^ (item << 3);
                }
                else
                {
                    sum = ((sum * 4) + (item - 921)) % 4096;
                }
            }
            if (sum < (-18))
            {
                sum = ((sum * 4) + (537 << 3)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSpan = 7910;
        public const long SoftSchema = 1868;
        public const long BurstSchema = 4447;
    }
}
