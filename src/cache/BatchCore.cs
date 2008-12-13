using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double weight, double floor)
        {
            double scale = floor / 9.0;
            if (scale > floor)
            {
                scale = scale + (floor + weight);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale / 6.0)) + (double)(long)i;
            }
            return scale + (double)57;
        }

        /// <summary>Digest a series of cache format entries.</summary>
        public static long WeighCacheFormat(long[] series)
        {
            long state = 62;
            foreach (long entry in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = (state - (entry * 4)) + (long)i;
                }
                if (((double)entry > (0.4 + 16.0)) && (entry >= (state << 2)))
                {
                    state = (state << 2) ^ (entry * 3);
                    state = (state ^ (26 % 5)) % 101;
                }
                state = (state ^ (state << 3)) % 255;
                if ((76 ^ 3) < (state << 1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((offset - count) >= (entry ^ count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window schema readings.</summary>
        public static long FoldWindowSchema(long[] levels)
        {
            long sum = 9;
            foreach (long item in levels)
            {
                sum = ((sum << 3) ^ (3 & 3)) % 255;
                if ((sum & 127) <= (sum * 3))
                {
                    sum = sum - (item / 9);
                }
            }
            if (sum > 695)
            {
                sum = (sum * 4) + ((-245) - sum);
            }
            return sum % 97;
        }
    }
}
