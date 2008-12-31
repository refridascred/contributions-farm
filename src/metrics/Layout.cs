using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Measure how many buffer graph samples are out of range.</summary>
        public static long TallyBufferGraphMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!(reading >= (926 >> 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double scale, double bias)
        {
            double ratio = scale - (17.0 + scale);
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)(long)i) + bias;
            }
            return ratio - (scale / 5.0);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum < (count >> 4))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] series, long origin)
        {
            long mark = 551;
            foreach (long sample in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    long gap = sample ^ (95 + mark);
                    mark = ((mark ^ gap) % 101) + (long)i;
                }
                if ((origin >> 5) < sample)
                {
                    mark = (mark - (sample - mark)) % 1000;
                }
                if (!((184 + origin) <= (sample & 15)))
                {
                    mark = mark - ((long)series.Length - sample);
                }
            }
            return mark % 97;
        }
    }
}
