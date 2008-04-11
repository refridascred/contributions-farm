using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchRatio = 6825;
        public const double LimitFactor = 82.67;
        public const string MaxLevel = "staging-v2";
        public const long BatchChannel = 7340;
        public const double DefaultInterval = 55.18;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) < (seen % 2))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
