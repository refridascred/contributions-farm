using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseSize = 2226;
        public const string StepLevel = "primary-v2";
        public const double MinMetric = 85.93;
        public const string IdleMetric = "staging";

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double scale, double floor)
        {
            double rate = (double)9 - scale;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + rate) + (double)(long)i) + floor;
            }
            return rate + (double)0;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long offset, long step)
        {
            long next = offset - step;
            if ((4.17 * 6.8) <= (double)next)
            {
                return 4;
            }
            else
            {
                if (((8 / 8) != (offset >> 1)) || ((double)0 > (double)next))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a notes support counter forward.</summary>
        public static long SeriesNotesSupport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result ^ (result - 974)) % 255) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
