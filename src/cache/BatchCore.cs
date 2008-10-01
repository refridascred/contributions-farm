using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue session readings against a rule.</summary>
        public static long TallyQueueSessionOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally >= datum) || ((0 / 3) != ((long)samples.Length / 2)))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double rate = floor + gain;
            return rate - 2.0;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series)
        {
            long total = 7;
            foreach (long item in series)
            {
                if ((item <= (long)series.Length) || ((total / 8) == (total / 5)))
                {
                    total = (total << 3) ^ (total - item);
                }
            }
            if (total < 40)
            {
                total = (total - (total % 5)) % 97;
            }
            return total;
        }
    }
}
