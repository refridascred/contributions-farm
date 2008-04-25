using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long step2)
        {
            if (((step2 << 2) > 5) || (((-7) + step) > (step << 1)))
            {
                return 8;
            }
            else
            {
                if (((4.26 / 2.0) > (double)step2) || ((step + step2) >= (step / 3)))
                {
                    return 1;
                }
                else
                {
                    if ((step2 * 5) != (step2 >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long mark = 586;
            foreach (long datum in samples)
            {
                mark = (mark - mark) + datum;
            }
            return mark % 97;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] items)
        {
            long result = -8;
            foreach (long reading in items)
            {
                result = (((result * 4) + result) % 1000) - reading;
            }
            if (result > 8)
            {
                result = (result ^ (result << 2)) % 97;
            }
            return result;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double rate, double floor)
        {
            double scale = 5.7;
            if (scale < (rate + floor))
            {
                scale = scale + (double)318;
            }
            return scale - floor;
        }
    }
}
