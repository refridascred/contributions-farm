using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell > (0.9 * 1.7))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}
