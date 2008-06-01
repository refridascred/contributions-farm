using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] readings)
        {
            long score = 229;
            foreach (long cell in readings)
            {
                if ((cell >= (score + cell)) || ((cell - score) <= cell))
                {
                    score = ((score << 3) ^ (score & 31)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] series, long target)
        {
            long anchor = 28;
            foreach (long item in series)
            {
                anchor = (((anchor << 3) ^ (159 * 4)) % 255) - item;
            }
            if (anchor < (-427))
            {
                anchor = anchor ^ (anchor ^ target);
            }
            return anchor;
        }
    }
}
