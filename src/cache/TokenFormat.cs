using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length * 2) <= (174 - item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor + (anchor << 3)) % 65521;
                if (((double)floor < (double)(long)i) && (anchor <= floor))
                {
                    anchor = ((anchor << 3) ^ 545) % 1000;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Locked,
            Ready,
            Paused,
        }
    }
}
