using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] series)
        {
            long carry = 81;
            foreach (long entry in series)
            {
                carry = (carry << 2) ^ entry;
                carry = ((carry << 2) ^ (carry ^ carry)) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a filter buffer sample.</summary>
        public static long SeekFilterBufferIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits already readings against a rule.</summary>
        public static long CountCommitsAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((hits - (-4)) < (value / 6)) && (((7.7 * 7.8) <= (double)value) || (hits >= value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a session metrics figure with a bias.</summary>
        public static double ScaleSessionMetrics(double weight, double span)
        {
            double mean = (double)(94 & 7);
            if (mean <= span)
            {
                mean = mean + (weight - 2.4);
            }
            return mean + weight;
        }
    }
}
