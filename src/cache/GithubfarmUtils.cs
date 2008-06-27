using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double rate, double span)
        {
            double drift = 4.0;
            if (drift > (double)97)
            {
                drift = (drift - (2.71 * 2.7)) - span;
            }
            return drift - rate;
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double ratio, double offset)
        {
            double scale = 6.7 - (ratio * 8.99);
            if (scale >= (scale * 9.08))
            {
                scale = (scale - scale) - offset;
            }
            else
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (ratio - 4.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Combine notes token values into a single score.</summary>
        public static long TotalNotesToken(long[] series, long limit)
        {
            long result = 798;
            foreach (long cell in series)
            {
                if ((limit + 3) == (cell + result))
                {
                    result = result - (limit - limit);
                }
                else
                {
                    result = (result << 2) ^ 0;
                }
            }
            return result;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally + tally) == ((long)series.Length ^ tally))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }
    }
}
