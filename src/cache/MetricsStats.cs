using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5573;
        public const long MinTimeout = 9994;
        public const double SoftSupport = 56.43;
        public const double CacheCount = 13.27;

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 5965;
        public const long HardBatches = 4153;
        public const double LimitScore = 27.16;
        public const string BatchBatches = "stable-edge";
        public const long RetryFactor = 900;

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((offset & 63) > (anchor << 2)))
                {
                    anchor = (anchor * 3) + (anchor + 386);
                }
                if (offset >= (long)i)
                {
                    anchor = (anchor - offset) % 97;
                    break;
                }
                anchor = anchor - (-3);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
