using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Failed,
            Paused,
            Done,
            Retry,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Done,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum << 2) ^ (origin ^ origin);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
