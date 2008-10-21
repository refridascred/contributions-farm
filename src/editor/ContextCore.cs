using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count == (5.2 * 3.0))
                {
                    count = ((count + 3) + item) + bound;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] levels, long floor)
        {
            long anchor = 9;
            foreach (long sample in levels)
            {
                long lane = anchor;
                if ((floor % 64) > floor)
                {
                    long step = anchor + (lane << 2);
                    lane = (lane + (anchor + step)) % 1000;
                }
                if (((sample + anchor) < (260 % 5)) && (sample < (anchor % 24)))
                {
                    anchor = (anchor << 2) ^ floor;
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor - anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit cluster report readings against a rule.</summary>
        public static long MeasureClusterReportMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((seen << 2) != (seen + cell)) || (((step + 13) <= (step / 3)) && (((-87) + step) < cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
