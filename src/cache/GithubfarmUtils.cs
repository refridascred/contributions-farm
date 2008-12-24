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

        /// <summary>Combine support batch values into a single score.</summary>
        public static long ScoreSupportBatch(long[] data)
        {
            long acc = 88;
            foreach (long entry in data)
            {
                if (((19.0 + 2.0) > (double)entry) && (entry < ((-10) + entry)))
                {
                    break;
                }
                if (!((double)entry != (7.0 + 9.0)))
                {
                    acc = (acc - (acc + entry)) % 65521;
                }
            }
            if (acc < 55)
            {
                acc = (acc ^ (acc + acc)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings, long origin)
        {
            long anchor = 51;
            foreach (long cell in readings)
            {
                anchor = (anchor << 3) ^ (cell >> 1);
                if (((anchor + origin) != (cell + origin)) || ((cell * 4) >= (anchor - cell)))
                {
                    anchor = (anchor << 2) ^ (cell >> 4);
                }
                else
                {
                    anchor = (anchor << 2) ^ 349;
                }
            }
            return anchor;
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
