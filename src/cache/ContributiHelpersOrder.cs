using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "local";
        public const double BatchSize = 14.94;
        public const long SoftWidth = 9737;
        public const string MinLevel = "latest-1";
        public const string SoftFactor = "staging-edge";
    }
}
