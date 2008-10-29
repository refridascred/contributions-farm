using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a editor session sample.</summary>
        public static long FindEditorSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor order entries that pass the check.</summary>
        public static long CountEditorOrderOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((13.0 - 3.07) > (double)hits)
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
