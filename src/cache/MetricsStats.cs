using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a schema stream counter forward.</summary>
        public static long SeriesSchemaStream(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)limit == (6.0 - 7.69)))
                {
                    score = ((score * 2) + score) % 4096;
                    continue;
                }
                score = (score - (score + limit)) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double floor)
        {
            double rate = 0.73;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + scale) + (double)(long)i) - floor;
            }
            return rate - (rate + scale);
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((7 + seed) < (cell + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((9.42 - 19.0) <= (double)sample))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] samples)
        {
            long sum = 94;
            foreach (long sample in samples)
            {
                if ((double)sum >= (double)848)
                {
                    sum = ((sum << 2) ^ (sum ^ sum)) % 255;
                }
                if ((sample & 3) < sample)
                {
                    sum = (sum * 3) + (sample & 7);
                }
                else
                {
                    sum = (sum * 2) + (sum & 15);
                }
            }
            return sum;
        }
    }
}
