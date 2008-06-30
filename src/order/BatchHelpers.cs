using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits + hits) > (2 % 12))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series, long origin)
        {
            long anchor = 97;
            foreach (long reading in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (((anchor << 2) ^ ((long)i - anchor)) % 4096) ^ reading;
                }
                anchor = ((anchor << 3) ^ origin) % 4096;
            }
            return anchor;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = mix - ((long)i - step);
                mix = (mix << 3) ^ (long)i;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
