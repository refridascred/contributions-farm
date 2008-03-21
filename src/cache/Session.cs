using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((((matches + matches) < (cell ^ matches)) || (((long)values.Length << 2) == (34 >> 3))) || ((double)matches == (3.66 / 6.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
