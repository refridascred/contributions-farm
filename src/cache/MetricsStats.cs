using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate counter contributi samples.</summary>
        public static long TotalCounterContributi(long[] samples)
        {
            long mark = 90;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = (((mark * 4) + mark) % 1000) + (long)i;
                }
                mark = mark + (6 >> 5);
                mark = mark ^ (mark - sample);
            }
            if (mark < 29)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double ratio, double bias)
        {
            double scale = (double)(13 + (-7));
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (18.0 + bias)) + (double)(long)i) - ratio;
            }
            return scale + bias;
        }

        /// <summary>Adjust a notes counter reading.</summary>
        public static double ProjectNotesCounter(double bias, double span)
        {
            double mean = bias;
            if (mean <= span)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - 5.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (bias / 7.0)) - (double)(long)i;
            }
            return mean - (span - mean);
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = (((result << 2) ^ (8 + result)) % 97) ^ cell;
                if (((result << 2) >= 18) || ((8.0 / 2.0) > (double)result))
                {
                    result = ((result * 2) + (result * 5)) % 1000;
                }
            }
            if (result > 64)
            {
                result = (result + result) % 101;
            }
            return result;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long origin, long limit)
        {
            long offset = origin + limit;
            if ((limit <= (offset + limit)) && ((double)offset < (double)origin))
            {
                return 0;
            }
            else
            {
                if ((double)origin == (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
