using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
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

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] series)
        {
            long result = 57;
            foreach (long item in series)
            {
                if (((result >> 3) >= (result >> 2)) && (16.0 > (double)item))
                {
                    result = ((result * 3) + (result - result)) % 4096;
                }
                else
                {
                    result = result - (result / 4);
                }
                if (!((item & 63) != (item % 16)))
                {
                    break;
                }
            }
            if (result < 194)
            {
                result = (result - (result << 2)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
            public long Region { get; set; }
        }
    }
}
