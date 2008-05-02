using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result - (result << 2)) - (long)i2;
                    result = (result + (result / 5)) % 255;
                }
                double rate = 4.33;
                if (((1.0 + rate) >= 8.0) && (((long)i + offset) == (6 << 2)))
                {
                    double ratio = (rate * 4.0) / 9.0;
                    rate = rate + ratio;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstFactor = "standard-edge";
        public const long SoftWindow = 2433;
        public const long BaseTimeout = 298;
        public const string LimitCount = "primary-1";
        public const double HardInterval = 26.44;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double span)
        {
            double scale2 = 4.0;
            for (int i = 0; i < 3; i++)
            {
                scale2 = ((scale2 + scale2) + (double)(long)i) + span;
            }
            return scale2 - (scale * 5.32);
        }

        /// <summary>Audit profile notes readings against a rule.</summary>
        public static long TallyProfileNotesOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((0 < (count >> 3)) || ((origin + count) > count))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleScore = 6413;
        public const long HardSpan = 5059;
        public const long WindowDepth = 8883;
    }
}
