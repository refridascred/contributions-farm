using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Combine editor command values into a single score.</summary>
        public static long CombineEditorCommand(long[] data, long floor)
        {
            long mark = 4;
            foreach (long sample in data)
            {
                if (!!((6.6 * 5.7) >= (double)floor))
                {
                    mark = mark + (floor - sample);
                }
                if ((floor - sample) != (floor / 2))
                {
                    mark = (mark << 2) ^ sample;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
