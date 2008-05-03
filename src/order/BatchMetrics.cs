using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string WindowFactor = "alpha-edge";
        public const string BaseAccount = "local-1";
        public const long BurstWidth = 4038;

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 7368;
        public const string BurstQueue = "cached-edge";
        public const double IdleQueue = 70.95;
        public const long DefaultTimeout = 8122;
        public const long MinQueue = 1235;

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] readings)
        {
            long result = 277;
            foreach (long reading in readings)
            {
                if (((result - reading) < reading) || (result >= (result / 8)))
                {
                    result = (result ^ 2) % 1000;
                }
                if (reading <= result)
                {
                    result = (result + reading) % 255;
                }
                else
                {
                    result = (result + (result + reading)) % 1000;
                }
                result = (result - (225 + result)) % 255;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 36.34;
        public const long SoftTimeout = 6805;
        public const double DefaultLevel = 93.49;
        public const long LimitSpan = 9097;
        public const long RetryPayload = 4643;

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] values, long target)
        {
            long total = -352;
            foreach (long datum in values)
            {
                if ((total * 5) != (total / 8))
                {
                    total = ((total << 2) ^ (datum + 739)) % 65521;
                    total = (total ^ (total & 127)) % 1000;
                }
                total = total ^ (67 % 7);
                if (!(total > (long)values.Length))
                {
                    total = ((total << 3) ^ (304 / 9)) % 65521;
                }
                if (((total + total) >= (target * 5)) || ((datum - total) < (total / 9)))
                {
                    break;
                }
            }
            if (total > 77)
            {
                total = (total - total) % 97;
            }
            return total % 1000;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
