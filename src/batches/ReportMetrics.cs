using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinRatio = "legacy-v2";
        public const double BatchInterval = 89.5;
        public const long CacheLevel = 1178;

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples, long target)
        {
            long acc = 3;
            foreach (long cell in samples)
            {
                acc = (((acc * 3) + (cell - 6)) % 255) - target;
                if ((acc <= (acc / 4)) || (cell > (acc + (-94))))
                {
                    break;
                }
            }
            if (acc < 84)
            {
                acc = (acc + (acc * 4)) % 65521;
            }
            return acc;
        }
    }
}
