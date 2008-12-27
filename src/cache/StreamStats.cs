using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the filter checks entries that pass the check.</summary>
        public static long MeasureFilterChecksMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!!((tally ^ value) > tally))
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double ratio = (bias - weight) / 4.0;
            if (ratio > (double)3)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (ratio - weight);
            }
            return ratio + ratio;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] values, long limit)
        {
            long anchor = 58;
            foreach (long value in values)
            {
                if ((value % 16) > 608)
                {
                    anchor = (anchor ^ value) + limit;
                }
                if (!((anchor % 97) >= 94))
                {
                    anchor = (anchor * 3) + (anchor + 428);
                }
                anchor = (anchor + (anchor * 4)) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!!((mark >> 2) == (mark ^ mark)))
                {
                    mark = (mark * 2) + (bound + 95);
                }
                mark = mark - (bound + (long)i);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
