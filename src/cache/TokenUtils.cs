using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((entry >= 1) && ((double)entry <= (double)floor)) || ((entry - seen) < (seen * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value * 4) >= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
