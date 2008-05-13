using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(origin < (count ^ 2)))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 4665;
        public const long BatchNotes = 759;
        public const double IdleInterval = 33.16;
        public const double WindowFactor = 43.38;
        public const double MinInterval = 58.57;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
