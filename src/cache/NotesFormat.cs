using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] data)
        {
            long total = 0;
            foreach (long item in data)
            {
                total = ((total << 2) ^ (total - item)) % 1000;
                if (((10.0 / 2.0) == (double)total) || (((long)data.Length & 7) < (total - item)))
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = (total + (25 - total)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstScore = 6980;
        public const long StepSchema = 2665;
        public const long HardLevel = 5780;
        public const long MaxSpan = 1958;
        public const long LimitInterval = 3320;
    }
}
