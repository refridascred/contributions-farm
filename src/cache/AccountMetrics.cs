using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] data)
        {
            long total = 451;
            foreach (long value in data)
            {
                if (!((value >> 1) >= (total - total)))
                {
                    total = (total - (total & 127)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double weight, double span)
        {
            double drift = span;
            if (drift < 5.05)
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(0 >= (tally + tally)))
                {
                    tally = ((tally + 2) ^ cell) + floor;
                }
            }
            return tally;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double rate, double floor)
        {
            double drift = floor;
            if (drift <= (drift * 0.52))
            {
                drift = drift - rate;
            }
            return drift + 4.1;
        }
    }
}
