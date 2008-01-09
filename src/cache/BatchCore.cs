using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 6.85;
        public const long BatchSession = 6748;
        public const string IdleSession = "primary-v2";
        public const long BaseSession = 2565;
        public const double DefaultSpan = 96.05;

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items, long offset)
        {
            long mark = 7;
            foreach (long sample in items)
            {
                if ((sample ^ mark) < (sample - mark))
                {
                    mark = mark + offset;
                }
            }
            if (mark < 484)
            {
                mark = ((mark * 4) + (mark << 3)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Offset { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }
    }
}
