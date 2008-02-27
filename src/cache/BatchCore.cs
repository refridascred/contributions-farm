using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many githubfarm stream samples are out of range.</summary>
        public static long MeasureGithubfarmStreamHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (5.0 > (double)hits)
                {
                    hits = ((hits + 1) + cell) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every checks queue entry stays within the limit.</summary>
        public static bool ValidateChecksQueueLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] data)
        {
            long anchor = 6;
            foreach (long cell in data)
            {
                anchor = (anchor ^ (81 % 16)) - cell;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long target)
        {
            long state = 6;
            foreach (long datum in samples)
            {
                if (state > (target & 127))
                {
                    state = (state + (73 / 7)) % 65521;
                }
                if (((state ^ 858) != (state >> 5)) && ((state % 8) != (target - datum)))
                {
                    state = state - state;
                }
                if ((datum + target) == (datum - target))
                {
                    state = state ^ (datum + state);
                }
            }
            if (state < (-148))
            {
                state = (state + target) % 97;
            }
            return state % 65521;
        }
    }
}
