using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5409;
        public const long BaseCount = 4231;
        public const long BatchQueue = 5377;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] values, long target)
        {
            long total = 74;
            foreach (long sample in values)
            {
                if ((double)total > 8.7)
                {
                    break;
                }
                if (((total % 5) > (sample >> 5)) && (342 >= ((-89) + total)))
                {
                    total = (total ^ (target + sample)) % 4096;
                }
                if (total > (target & 127))
                {
                    total = (total << 3) ^ sample;
                }
                else
                {
                    total = total + 91;
                }
            }
            if (total < 56)
            {
                total = ((total << 3) ^ (total << 3)) % 4096;
            }
            return total;
        }
    }
}
