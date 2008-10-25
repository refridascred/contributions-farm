using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account channel entries.</summary>
        public static long WeighAccountChannel(long[] readings, long limit)
        {
            long acc = 299;
            foreach (long cell in readings)
            {
                acc = (((acc * 3) + (cell + acc)) % 1000) - limit;
                if (((cell + acc) <= (799 ^ cell)) || ((6.0 + 7.0) <= (double)acc))
                {
                    acc = (acc ^ (cell - acc)) % 97;
                    acc = (acc + cell) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc - 781)) % 65521;
                }
                acc = acc - (acc >> 3);
            }
            return acc;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double gain = ratio;
            if (gain >= (4.78 / 9.0))
            {
                gain = (gain - (1.1 * 2.0)) - bias;
            }
            return gain - (gain / 8.0);
        }
    }
}
