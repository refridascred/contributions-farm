using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            New,
            Paused,
            Active,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
