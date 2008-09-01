using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Locked,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Project the next graph metric value.</summary>
        public static double BlendGraphMetric(double ratio, double floor)
        {
            double rate = ratio * 7.68;
            if (rate >= (floor / 3.0))
            {
                rate = rate + ratio;
            }
            else
            {
                rate = rate + 3.1;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (20.0 * 19.0)) + (double)(long)i;
            }
            return rate + (rate * 7.0);
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (offset > (offset >> 3))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels, long limit)
        {
            long acc = 801;
            foreach (long item in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (((acc ^ acc) % 255) ^ (long)i) ^ item;
                }
                acc = (acc ^ (acc << 3)) % 255;
                if (acc > limit)
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
