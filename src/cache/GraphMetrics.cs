using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] levels)
        {
            long acc = -154;
            foreach (long value in levels)
            {
                if (value <= (value * 3))
                {
                    acc = (acc - (acc << 3)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double weight, double bias)
        {
            double mean = weight;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + 4.0) + (double)(long)i) - bias;
            }
            return mean + (mean / 7.0);
        }

        /// <summary>Digest a series of farm tools entries.</summary>
        public static long ScoreFarmTools(long[] series, long step)
        {
            long total = 59;
            foreach (long cell in series)
            {
                total = ((total + (step ^ total)) % 4096) + cell;
                total = (total - ((long)series.Length - 118)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Validate cache graph readings against a bound.</summary>
        public static bool ValidateCacheGraphLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
