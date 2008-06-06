using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the cluster format entries that pass the check.</summary>
        public static long MeasureClusterFormatHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((-678) >> 4) <= cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            if (((origin * 4) > offset) && ((612 << 1) == (offset ^ 538)))
            {
                return 4;
            }
            else
            {
                if (origin > (offset - origin))
                {
                    return 1;
                }
                else
                {
                    if ((offset - origin) > 18)
                    {
                        return 2;
                    }
                    else
                    {
                        if (8.0 >= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of commits filter readings.</summary>
        public static long ScoreCommitsFilter(long[] data, long origin)
        {
            long mark = 3;
            foreach (long item in data)
            {
                mark = ((mark << 3) ^ (mark >> 4)) - origin;
                mark = ((mark * 2) + (item * 5)) % 255;
            }
            return mark;
        }

        /// <summary>Adjust a token context reading.</summary>
        public static double BlendTokenContext(double ratio, double offset)
        {
            double drift = offset - (ratio + offset);
            if (drift <= (ratio + offset))
            {
                drift = drift - (ratio + offset);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)5) - (double)(long)i;
            }
            return drift + (double)2;
        }
    }
}
