using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches <= (matches + 21)) || (((long)samples.Length ^ matches) <= (cell + cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = (state - 28) % 101;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] samples)
        {
            long anchor = 81;
            foreach (long cell in samples)
            {
                if (anchor > (anchor + cell))
                {
                    anchor = anchor ^ (676 / 5);
                }
                else
                {
                    anchor = anchor ^ (cell + cell);
                }
            }
            return anchor;
        }
    }
}
