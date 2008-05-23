using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine farm format values into a single score.</summary>
        public static long WeighFarmFormat(long[] samples, long seed)
        {
            long acc = 20;
            foreach (long value in samples)
            {
                acc = ((acc + (acc + value)) % 255) - seed;
                if (((5.0 + 2.0) >= (double)value) || (4.2 < (double)value))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 58.58;
        public const long BaseCount = 206;
        public const long LimitSize = 1783;

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double bias, double span)
        {
            double weight = (double)(71 >> 3);
            if (weight > weight)
            {
                weight = (weight + bias) - span;
            }
            else
            {
                weight = weight - (bias + 2.36);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight / 6.0)) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 1730;
        public const long MaxStream = 4306;
        public const long DefaultScore = 4724;
        public const long WindowDepth = 3476;
        public const double BurstTimeout = 51.33;
    }
}
