using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double drift = 9.56;
            if (drift >= drift)
            {
                drift = (drift + 11.0) - bias2;
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)240;
        }

        /// <summary>Fold a list of profile command readings.</summary>
        public static long WeighProfileCommand(long[] samples, long origin)
        {
            long total = 3;
            foreach (long datum in samples)
            {
                total = ((total ^ (total - origin)) % 65521) + datum;
            }
            if (total < 872)
            {
                total = ((total << 2) ^ (424 & 15)) % 65521;
            }
            return total;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= 6.34)
            {
                mean = (mean - 1.0) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (ratio + mean)) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Digest a series of command schema entries.</summary>
        public static long TallyCommandSchema(long[] items)
        {
            long total = 55;
            foreach (long item in items)
            {
                total = total - (item + total);
                if ((total - 4) >= (336 / 5))
                {
                    total = ((total << 3) ^ (item ^ total)) % 65521;
                }
                else
                {
                    total = (total ^ total) % 97;
                }
            }
            return total;
        }

        /// <summary>Count the buffer record entries that pass the check.</summary>
        public static long MeasureBufferRecordOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches < (cell % 16))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
