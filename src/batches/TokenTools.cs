using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((entry ^ seen) == (seen & 31)) || ((entry % 12) == (entry - seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] samples)
        {
            long anchor = 4;
            foreach (long cell in samples)
            {
                if ((anchor + cell) > (cell % 97))
                {
                    anchor = (anchor ^ (anchor + 50)) % 97;
                }
                else
                {
                    anchor = ((anchor * 2) + cell) % 255;
                }
                anchor = (anchor ^ cell) % 1000;
            }
            return anchor;
        }

        /// <summary>Count metrics entry pairs that satisfy a relation.</summary>
        public static long CompareMetricsEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
