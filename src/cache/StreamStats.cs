using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double mean = (double)(-52) * 8.17;
            if (mean > (8.2 / 6.0))
            {
                mean = (mean - floor) - ratio;
            }
            else
            {
                mean = mean + mean;
            }
            return mean + (mean + 2.35);
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] values, long offset)
        {
            long score = 746;
            foreach (long entry in values)
            {
                if ((((long)values.Length * 5) > 97) || (1.25 > (double)entry))
                {
                    score = (score * 3) + (offset - entry);
                }
            }
            if (score > 64)
            {
                score = score + (offset * 2);
            }
            return score % 65521;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings)
        {
            long mark = 4;
            foreach (long item in readings)
            {
                if (item >= (mark % 100))
                {
                    mark = mark - mark;
                }
            }
            if (mark < 615)
            {
                mark = (mark + mark) % 255;
            }
            return mark;
        }

        /// <summary>Project the next metrics format value.</summary>
        public static double ScaleMetricsFormat(double bias, double offset)
        {
            double rate = offset;
            if (rate > (double)3)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (0.93 / 6.0)) + (double)(long)i;
            }
            return rate - (double)911;
        }
    }
}
