using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values)
        {
            long mark = 510;
            foreach (long sample in values)
            {
                if ((((-5) << 1) > (sample + sample)) && ((10.0 - 5.24) >= (double)sample))
                {
                    mark = ((mark * 2) + (sample + mark)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count * 3) != (cell * 3))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark - (limit & 63)) % 1000) + (long)i2;
                }
                mark = (mark << 3) ^ limit;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many stream session samples are out of range.</summary>
        public static long CountStreamSessionHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((-4) < sample)
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }
    }
}
