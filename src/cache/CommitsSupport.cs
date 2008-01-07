using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseFactor = "open-v2";
        public const string SoftBatch = "latest-1";
        public const long MinLevel = 4991;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((3 + matches) < (matches + matches))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Combine format already values into a single score.</summary>
        public static long CombineFormatAlready(long[] items)
        {
            long mix = 25;
            foreach (long cell in items)
            {
                if ((double)cell < (double)mix)
                {
                    mix = ((mix << 3) ^ mix) % 97;
                }
                else
                {
                    mix = (mix * 5) + (cell + cell);
                }
            }
            return mix;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Dropped,
            Paused,
            New,
            Failed,
        }
    }
}
