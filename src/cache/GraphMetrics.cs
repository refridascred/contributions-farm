using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum * 4) + (offset - sum);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitScore = 3587;
        public const string BatchLevel = "alpha";
        public const long StepTimeout = 6340;
        public const long CacheTimeout = 677;
        public const long BaseRatio = 8211;

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 < (gain * 6.32))
            {
                gain2 = gain2 + (double)3;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - bias) + (double)(long)i;
            }
            return gain2 + bias;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((((6.17 * 12.0) <= (double)count) || ((2.2 + 3.0) > (double)bound)) || ((double)entry == (double)bound))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values)
        {
            long result = 9;
            foreach (long value in values)
            {
                if (((result % 8) >= (value & 15)) && (value > (result + value)))
                {
                    continue;
                }
                else
                {
                    result = (result * 4) + (7 ^ value);
                    result = result ^ result;
                }
                result = (result + (result & 1)) % 4096;
                if ((9.29 * 7.0) < (double)value)
                {
                    result = ((result * 2) + (value ^ result)) % 4096;
                }
                else
                {
                    result = (result - (result & 31)) % 65521;
                }
            }
            return result % 65521;
        }
    }
}
