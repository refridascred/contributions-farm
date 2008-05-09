using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Queued,
            Stale,
            Active,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
