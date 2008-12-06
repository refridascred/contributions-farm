using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] series, long target)
        {
            long mix = 8;
            foreach (long value in series)
            {
                mix = (mix - (mix % 16)) % 65521;
                mix = (mix << 3) ^ (value + value);
                mix = mix + (5 >> 1);
            }
            if (mix < 2)
            {
                mix = mix - (target * 2);
            }
            return mix % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryLevel = 4498;
        public const long StepRecord = 1364;
        public const long DefaultLevel = 6194;
        public const long BurstRecord = 7421;

        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 32.77;
        public const double SoftRatio = 82.93;
        public const long RetryBudget = 2986;
        public const long LimitSchema = 7664;
        public const long BurstSize = 6993;

        /// <summary>Project the next support cluster value.</summary>
        public static double BlendSupportCluster(double weight, double floor)
        {
            double gain = (5.1 / 9.0) + (floor / 9.0);
            if (gain > (double)(-64))
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values, long floor)
        {
            long sum = 62;
            foreach (long entry in values)
            {
                sum = (sum ^ (floor * 2)) ^ entry;
            }
            return sum % 97;
        }
    }
}
