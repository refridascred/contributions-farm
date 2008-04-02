using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + tally) == (reading + 347))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values, long limit)
        {
            long mark = 648;
            foreach (long sample in values)
            {
                if ((limit & 63) < 455)
                {
                    mark = (((mark * 3) + (mark >> 5)) % 1000) - sample;
                }
                else
                {
                    mark = (mark ^ (limit & 63)) % 255;
                }
            }
            if (mark < 840)
            {
                mark = mark + (mark + limit);
            }
            return mark;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double bias = (double)33 - 14.0;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (floor - 4.61)) + (double)(long)i;
            }
            return bias + scale;
        }
    }
}
